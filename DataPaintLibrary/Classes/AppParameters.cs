
namespace DataPaintLibrary.Classes
{
    public class AppParameters : IAppParameters
    {
        public static string GetExcelConnection(string FilePath)
        {

            string ExcelConnection = string.Concat(@"Provider=Microsoft.Jet.OLEDB.4.0;",
                                                     FilePath,
                                                     @"Extended Properties='Excel 8.0;HDR=Yes;'");

            return ExcelConnection;
        }
    }
}
