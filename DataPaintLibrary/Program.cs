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

            OrchestratorService _orchestratorService = new OrchestratorService();
            _orchestratorService.Run(dataList);



            //Extract data
            //string excelTestFile = @"C:\Users\craig\Desktop\Spreadsheets\Level Push CN.xlsx";

            //DataSet excelData = DataExtraction.GetExcelDataSet(excelTestFile);


            //DataTable wantedSheet = excelData.Tables["levels"]; //store extractions
            //                                                    //now format the extractions

        }

        private static List<DataInput> TestData()
        {
            var dataList = new List<DataInput>();
            var data = new DataInput()
            {
                ExtractionType = Enums.ExtractionType.Excel,
                Location = @"C:\Users\craig\Desktop\Spreadsheets\Level Push CN.xlsx"
            };

            var sheet = new SheetInput()
            {
                SheetName = "Levels",
                IncludeHeader = true,
                StartRow = 10,
                EndRow = 17,
                StartColumn = 1,
                EndColumn = 12
            };

            data.Sheets.Add(sheet);

            sheet = new SheetInput()
            {
                SheetName = "Days",
                IncludeHeader = false,
                StartRow = 4,
                EndRow = 10,
                StartColumn = 2,
                EndColumn = 7
            };

            data.Sheets.Add(sheet);

            sheet = new SheetInput()
            {
                SheetName = "DayType",
                IncludeHeader = true,
                StartRow = 1,
                EndRow = 7,
                StartColumn = 1,
                EndColumn = 2
            };

            data.Sheets.Add(sheet);
            dataList.Add(data);
            return dataList;
        }
    }
}
