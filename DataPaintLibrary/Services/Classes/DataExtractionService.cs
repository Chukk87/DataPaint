using DataPaintLibrary.Services.Interfaces;
using System;
using System.Data;
using ExcelDataReader;
using System.IO;
using System.Reflection;

namespace DataPaintLibrary.Services.Classes
{
    public class DataExtractionService : IDataExtractionService
    {
        private readonly ILoggerService _loggerService;

        public DataExtractionService(ILoggerService loggerService)
        {
            _loggerService = loggerService;
        }

        /// <summary>
        /// Creates a Dataset of a selected Excel file.
        /// </summary>
        /// <param name="filePath">The path to the Excel file.</param>
        /// <returns>Excel Dataset, or null if the extraction fails.</returns>
        /// <exception cref="FileNotFoundException">Thrown if the file does not exist.</exception>
        public DataSet GetExcelDataSet(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                _loggerService.LogInfo("File path cannot be null or empty.", MethodBase.GetCurrentMethod().Name);

                throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
            }

            DataSet excelDataSet = new DataSet();

            try
            {
                using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                    using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        // Use the AsDataSet extension method to convert to DataSet
                        excelDataSet = reader.AsDataSet(new ExcelDataSetConfiguration());
                    }
                }
            }
            catch (Exception ex)
            {
                _loggerService.RecordException(ex, MethodBase.GetCurrentMethod().Name);
                throw;
            }

            return excelDataSet;
        }
    }
}