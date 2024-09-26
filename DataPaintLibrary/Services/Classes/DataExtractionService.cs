using DataPaintLibrary.Services.Interfaces;
using System;
using System.Data;
using ExcelDataReader;
using System.IO;

namespace DataPaintLibrary.Services.Classes
{
    public class DataExtractionService : IDataExtractionService
    {
        /// <summary>
        /// Creates a Dataset of a selected excel file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>Excel Dataset</returns>
        public DataSet GetExcelDataSet(string filePath)
        {
            DataSet excelDataSet = new DataSet();

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Use the AsDataSet extension method to convert to DataSet
                    var result = reader.AsDataSet(new ExcelDataSetConfiguration());
                    excelDataSet = result;
                }
            }

            return excelDataSet;
        }
    }
}