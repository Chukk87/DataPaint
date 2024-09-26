using DataPaintLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using DataPaintLibrary.Classes.Input;


namespace DataPaintLibrary.Services.Classes
{
    class SqlService
    {
        private static string connectionString = "Data Source=your_server;Initial Catalog=Localhost;Integrated Security=True";

        /// <summary>
        /// Collects all details from SQL to populate the required class lists for the data parameters
        /// </summary>
        /// <returns></returns>
        public async Task<List<DataInput>> GetAllInputDataParameters()
        {
            //Get datainput for ExtractionType, DataType, Location, Sheetname Log

            var dataInput = new List<DataInput>();

            var dataInputTable = await GetSqlDataInputTable();
            var sheetInputTable = await GetSqlSheetInputTable();


            return dataInput;

        }

        /// <summary>
        /// Collects the Excel sheet input parameters
        /// </summary>
        /// <returns></returns>
        private async Task<DataTable> GetSqlSheetInputTable()
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    await connection.OpenAsync();

                    // Create a command to execute the stored procedure
                    using (SqlCommand command = new SqlCommand("GetEmployeesByDepartment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the parameter to the stored procedure
                        command.Parameters.AddWithValue("@DepartmentId", 1);

                        // Create a data adapter to fill the DataTable with the result
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Fill the DataTable with the result of the stored procedure
                            adapter.Fill(resultTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return resultTable;
        }

        /// <summary>
        ///  Collects the Excel data parameters
        /// </summary>
        /// <returns></returns>
        private async Task<DataTable> GetSqlDataInputTable()
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    await connection.OpenAsync();

                    // Create a command to execute the stored procedure
                    using (SqlCommand command = new SqlCommand("GetEmployeesByDepartment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add the parameter to the stored procedure
                        command.Parameters.AddWithValue("@DepartmentId", 1);

                        // Create a data adapter to fill the DataTable with the result
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Fill the DataTable with the result of the stored procedure
                            adapter.Fill(resultTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return resultTable;
        }


        public async Task<List<OwnerGroup>> GetOwnerGroups()
        {
            var resultTable = new DataTable();
            var ownerGroups = new List<OwnerGroup>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    await connection.OpenAsync();

                    // Create a command to execute the stored procedure
                    using (SqlCommand command = new SqlCommand("[App].[GetOwnerGroups]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Create a data adapter to fill the DataTable with the result
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Fill the DataTable with the result of the stored procedure
                            adapter.Fill(resultTable);
                        }
                    }

                    //Build class list
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return ownerGroups;
        }
    }
}
