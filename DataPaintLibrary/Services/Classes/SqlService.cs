using System;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using DataPaintLibrary.Services.Interfaces;
using System.Reflection;
using System.Collections.Generic;
using DataPaintLibrary.Classes.Input;

namespace DataPaintLibrary.Services.Classes
{
    public class SqlService : ISqlService
    {
        private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DataPaint;Integrated Security=True;TrustServerCertificate=True";
        private readonly ILoggerService _loggerService;

        public SqlService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        public async Task<DataTable> GetUsers()
        {
            return await ExecuteQueryAsync("App.GetUsers");
        }

        public async Task CreateSecurityGroup(string securityGroup)
        {
            var parameters = new[]
{
                new SqlParameter("@SecurityGroupName", securityGroup),
                new SqlParameter("@ErrorCode", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            await ExecuteNonQueryAsync("App.CreateSecurityGroup", parameters);
        }

        public async Task<DataTable> GetSecurityGroups()
        {
            return await ExecuteQueryAsync("App.GetSecurityGroups");
        }

        public async Task<DataTable> GetUserSecurity()
        {
            return await ExecuteQueryAsync("App.GetUserSecurity");
        }

        public async Task<DataTable> GetSqlSheetInputTable()
        {
            return await ExecuteQueryAsync("GetEmployeesByDepartment", new SqlParameter("@DepartmentId", 1));
        }

        public async Task<DataTable> GetSqlDataInputTable()
        {
            return await ExecuteQueryAsync("App.GetDataInputTable");
        }

        public async Task<DataTable> GetOwnerGroups()
        {
            return await ExecuteQueryAsync("[App].[GetOwnerGroups]");
        }

        public async Task CreateOwnerGroup(string name, string contactEmail, string phoneNumber)
        {
            var parameters = new[]
            {
                new SqlParameter("@GroupName", name),
                new SqlParameter("@ContactEmail", contactEmail),
                new SqlParameter("@PhoneNumber", phoneNumber),
                new SqlParameter("@ErrorCode", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            // Execute the stored procedure to create the owner group
            await ExecuteNonQueryAsync("App.CreateOwnerGroup", parameters);


            var errorCode = (int)parameters[3].Value;

            if (errorCode != 0)
            {
                throw new Exception($"Stored Procedure Error: {errorCode}");
            }
        }

        private async Task<DataTable> ExecuteQueryAsync(string storedProcedureName, params SqlParameter[] parameters)
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    _loggerService.RecordException(ex, MethodBase.GetCurrentMethod().Name);
                    throw;
                }
            }

            return resultTable;
        }

        private async Task ExecuteNonQueryAsync(string storedProcedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        await command.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception ex)
                {
                    _loggerService.RecordException(ex, MethodBase.GetCurrentMethod().Name);
                    throw;
                }
            }
        }
    }
}