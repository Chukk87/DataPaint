using DataPaintLibrary.Classes;
using DataPaintLibrary.Services.Classes;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataPaintLibrary
{
    class Program
    {
        //Get user

        //Get Available Reports
        //private List<Report> AvailableReports = new List<Report>();

        //Get Orientation Templates

        static void Main(string[] args)
        {
            //Test Data
            List<DataInput> dataList = TestData();

            //_orchestratorService.Run(dataList);



            //Extract data
            //string excelTestFile = @"C:\Users\craig\Desktop\Spreadsheets\Level Push CN.xlsx";

            //DataSet excelData = DataExtraction.GetExcelDataSet(excelTestFile);


            //DataTable wantedSheet = excelData.Tables["levels"]; //store extractions
            //                                                    //now format the extractions

        }

        private static List<DataInput> TestData()
        {
            var dataList = new List<DataInput>();

            // Create a new instance of DataInput with all required properties
            var data = new DataInput(1, "Test Data Input", 1, Enums.ExtractionType.Excel, Enums.DataType.Dynamic, 
                                    @"C:\Users\craig\Desktop\Spreadsheets\Level Push CN.xlsx");

            // Add sheets to the data input using the constructor
            data.Sheets.Add(new SheetInput("Levels", true, 10, 17, 1, 12));

            data.Sheets.Add(new SheetInput("Days", false, 4, 10, 2, 7));

            data.Sheets.Add(new SheetInput("DayType", true, 1, 7, 1, 2));

            // Add the populated DataInput to the list
            dataList.Add(data);

            return dataList;
        }
    }
}
