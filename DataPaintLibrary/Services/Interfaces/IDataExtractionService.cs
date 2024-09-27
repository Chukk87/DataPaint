using System.Data;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface IDataExtractionService
    {
        DataSet GetExcelDataSet(string filePath);
    }
}