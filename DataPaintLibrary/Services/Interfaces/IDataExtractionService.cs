using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IDataExtractionService
    {
        /// <summary>
        /// Extracts Excel data based on a given filepath
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        DataSet GetExcelDataSet(string filePath);
    }
}