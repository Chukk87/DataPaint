using System;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using DataPaintLibrary.Services.Interfaces;
using System.Reflection;

namespace DataPaintLibrary.Services.Classes
{
    public class SqlService : ISqlService
    {
        private static string connectionString = "Data Source=your_server;Initial Catalog=Localhost;Integrated Security=True";
        private readonly ILoggerService _loggerService;

        public SqlService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
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
    }
}