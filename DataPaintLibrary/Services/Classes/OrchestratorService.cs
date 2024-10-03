using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Orientation;
using DataPaintLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataPaintLibrary.Services.Interfaces;

namespace DataPaintLibrary.Services.Classes
{
    public class OrchestratorService : IOrchestratorService
    {
        private List<DataInput> _dataInputs;
        private SheetInput _mockSheetInput;
        private List<OrientationTemplate> _orientationTemplates;
        private readonly IDataExtractionService _dataExtraction;

        public OrchestratorService(IDataExtractionService dataExtraction)
        {
            _dataExtraction = dataExtraction;
        }

        public void Run(List<DataInput> dataInputs)
        {
            _dataInputs = dataInputs;

            DataCollection();
            InputDataFormat();
        }

        public void MockRun(SheetInput mockSheetInput)
        {
            _mockSheetInput = mockSheetInput;

            MockInputDataFormat();
        }

        private void DataCollection()
        {
            foreach (DataInput input in _dataInputs)
            {
                switch (input.ExtractionType)
                {
                    case ExtractionType.Api:
                        // Handle API extraction here
                        Console.WriteLine($"API extraction not implemented for {input.Name}.");
                        break;
                    case ExtractionType.Excel:
                        input.ExcelDataSet = _dataExtraction.GetExcelDataSet(input.Location);
                        break;
                    case ExtractionType.TextDelimiter:
                        // Handle text delimiter extraction here
                        Console.WriteLine($"Text Delimiter extraction not implemented for {input.Name}.");
                        break;
                    case ExtractionType.TextTab:
                        // Handle text tab extraction here
                        Console.WriteLine($"Text Tab extraction not implemented for {input.Name}.");
                        break;
                }
            }
        }

        private void InputDataFormat()
        {
            foreach (DataInput input in _dataInputs)
            {
                foreach (SheetInput sheet in input.Sheets)
                {
                    sheet.FormattedTable = input.ExcelDataSet.Tables[sheet.SheetName].Copy();
                    RemoveRowsFromEnd(sheet);
                    RemoveRowsFromStart(sheet);
                    RemoveColumnsFromEnd(sheet);
                    RemoveColumnsFromStart(sheet);
                    MakeTopRowHeaders(sheet);
                }
            }
        }

        private void MockInputDataFormat()
        {
            RemoveRowsFromEnd(_mockSheetInput);
            RemoveRowsFromStart(_mockSheetInput);
            RemoveColumnsFromEnd(_mockSheetInput);
            RemoveColumnsFromStart(_mockSheetInput);
            MakeTopRowHeaders(_mockSheetInput);
        }

        private static void RemoveRowsFromEnd(SheetInput sheet)
        {
            if (sheet.EndRow > 0)
            {
                for (int i = sheet.FormattedTable.Rows.Count - 1; i >= sheet.EndRow; i--)
                {
                    sheet.FormattedTable.Rows[i].Delete();
                }
                sheet.FormattedTable.AcceptChanges();
            }
        }

        private static void RemoveRowsFromStart(SheetInput sheet)
        {
            if (sheet.StartRow > 1 && sheet.StartRow <= sheet.FormattedTable.Rows.Count)
            {
                for (int i = sheet.StartRow - 2; i >= 0; i--)
                {
                    sheet.FormattedTable.Rows[i].Delete();
                }
                sheet.FormattedTable.AcceptChanges();
            }
        }

        private void RemoveColumnsFromStart(SheetInput sheet)
        {
            for (int i = sheet.StartColumn- 1; i >= 1; i--)
            {
                sheet.FormattedTable.Columns.RemoveAt(i);
            }
        }

        private void RemoveColumnsFromEnd(SheetInput sheet)
        {
            for (int i = sheet.FormattedTable.Columns.Count - 1; i > sheet.EndColumn; i--)
            {
                sheet.FormattedTable.Columns.RemoveAt(i);
            }
        }

        private void MakeTopRowHeaders(SheetInput sheet)
        {
            if(sheet.IncludeHeader)
            {
                DataRow headerRow = sheet.FormattedTable.Rows[0];

                for (int i = 0; i < sheet.FormattedTable.Columns.Count; i++)
                {
                    sheet.FormattedTable.Columns[i].ColumnName = headerRow[i].ToString();
                }

                sheet.FormattedTable.Rows[0].Delete();
                sheet.FormattedTable.AcceptChanges();
            }
        }

        private void FilterTable(SheetInput sheet, Dictionary<string, object> parameters)
        {
            string columnName = parameters["ColumnName"].ToString();
            string filterValue = parameters["FilterValue"].ToString();

            var filteredRows = sheet.FormattedTable.AsEnumerable()
                .Where(row => row.Field<string>(columnName) == filterValue);

            sheet.FormattedTable = filteredRows.CopyToDataTable();
        }

        private void SortTable(SheetInput sheet, Dictionary<string, object> parameters)
        {
            string columnName = parameters["ColumnName"].ToString();
            bool ascending = (bool)parameters["Ascending"];

            var sortedRows = ascending
                ? sheet.FormattedTable.AsEnumerable().OrderBy(row => row.Field<string>(columnName))
                : sheet.FormattedTable.AsEnumerable().OrderByDescending(row => row.Field<string>(columnName));

            sheet.FormattedTable = sortedRows.CopyToDataTable();
        }

        private void GroupTable(SheetInput sheet, Dictionary<string, object> parameters)
        {
            string groupByColumn = parameters["GroupByColumn"].ToString();
            var groupedRows = from row in sheet.FormattedTable.AsEnumerable()
                              group row by row.Field<string>(groupByColumn) into grp
                              select new
                              {
                                  GroupKey = grp.Key,
                                  Count = grp.Count(),
                              };

            DataTable groupedTable = new DataTable();
            groupedTable.Columns.Add("GroupKey", typeof(string));
            groupedTable.Columns.Add("Count", typeof(int));

            foreach (var group in groupedRows)
            {
                groupedTable.Rows.Add(group.GroupKey, group.Count);
            }

            sheet.FormattedTable = groupedTable;
        }

        private void TransformData(SheetInput sheet, Dictionary<string, object> parameters)
        {
            string columnName = parameters["ColumnName"].ToString();
            string transformationType = parameters["TransformationType"].ToString();

            foreach (DataRow row in sheet.FormattedTable.Rows)
            {
                if (transformationType == "Uppercase")
                {
                    row[columnName] = row[columnName].ToString().ToUpper();
                }
                else if (transformationType == "Lowercase")
                {
                    row[columnName] = row[columnName].ToString().ToLower();
                }
            }
        }

        private void MergeTables(SheetInput sheet, Dictionary<string, object> parameters)
        {
            DataTable otherTable = parameters["OtherTable"] as DataTable;
            string mergeOnColumn = parameters["MergeOnColumn"].ToString();

            var mergedRows = from row1 in sheet.FormattedTable.AsEnumerable()
                             join row2 in otherTable.AsEnumerable()
                             on row1.Field<string>(mergeOnColumn) equals row2.Field<string>(mergeOnColumn)
                             select new
                             {
                                 Col1 = row1.Field<string>("Column1"),
                                 Col2 = row2.Field<string>("Column2")
                             };

            DataTable mergedTable = new DataTable();
            mergedTable.Columns.Add("Column1", typeof(string));
            mergedTable.Columns.Add("Column2", typeof(string));

            foreach (var row in mergedRows)
            {
                mergedTable.Rows.Add(row.Col1, row.Col2);
            }

            sheet.FormattedTable = mergedTable;
        }

        private void RemoveDuplicates(SheetInput sheet, Dictionary<string, object> parameters)
        {
            string columnName = parameters["ColumnName"].ToString();

            var distinctRows = sheet.FormattedTable.AsEnumerable()
                .GroupBy(row => row.Field<string>(columnName))
                .Select(g => g.First());

            sheet.FormattedTable = distinctRows.CopyToDataTable();
        }
    }
}