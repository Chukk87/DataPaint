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
                }
            }
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
            for (int i = sheet.StartColumn - 1; i >= 0; i--)
            {
                if (i < sheet.FormattedTable.Columns.Count)
                {
                    sheet.FormattedTable.Columns.RemoveAt(i);
                }
            }
        }

        private void RemoveColumnsFromEnd(SheetInput sheet)
        {
            for (int i = sheet.FormattedTable.Columns.Count - 1; i > sheet.EndColumn; i--)
            {
                sheet.FormattedTable.Columns.RemoveAt(i);
            }
        }
    }
}