using DataPaintLibrary.Classes;
using DataPaintLibrary.Classes.Orientation;
using DataPaintLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataPaintLibrary.Services.Interfaces;

namespace DataPaintLibrary.Services.Classes
{
    public class OrchestratorService
    {
        private List<DataInput> DataList;
        private IDataExtractionService dataExtraction = new DataExtractionService();

        public void Run(int Id)
        {
            //Get Id from SQL to pass here and collect needed data
        }

        /// <summary>
        /// Runs the orchestrator servive for all; collects data > Orientates data > Outputs data
        /// </summary>
        /// <param name="dataInputs"></param>
        public void Run(List<DataInput> dataInputs)
        {
            DataList = dataInputs;

            DataCollection();
            InputDataFormat();

        }

        /// <summary>
        /// Collects all the data required for the required outpur reports
        /// </summary>
        private void DataCollection()
        {
            foreach (DataInput input in DataList)
            {
                switch (input.ExtractionType)
                {
                    case ExtractionType.Api:
                        break;
                    case ExtractionType.Excel:
                        input.ExcelDataSet = dataExtraction.GetExcelDataSet(input.Location);
                        break;
                    case ExtractionType.TextDelimiter:
                        break;
                    case ExtractionType.TextTab:
                        break;
                }
            }
        }

        /// <summary>
        /// Collects the data required for the Id which are required for the output reports
        /// </summary>
        private void DataCollection(int id)
        {
            foreach (DataInput input in DataList)
            {
                switch (input.ExtractionType)
                {
                    case ExtractionType.Api:
                        break;
                    case ExtractionType.Excel:
                        input.ExcelDataSet = dataExtraction.GetExcelDataSet(input.Location);
                        break;
                    case ExtractionType.TextDelimiter:
                        break;
                    case ExtractionType.TextTab:
                        break;
                }
            }
        }

        /// <summary>
        /// Collects the data required for a list of Id's which are required for the output reports
        /// </summary>
        private void DataCollection(List<int> ids)
        {
            foreach (DataInput input in DataList)
            {
                switch (input.ExtractionType)
                {
                    case ExtractionType.Api:
                        break;
                    case ExtractionType.Excel:
                        input.ExcelDataSet = dataExtraction.GetExcelDataSet(input.Location);
                        break;
                    case ExtractionType.TextDelimiter:
                        break;
                    case ExtractionType.TextTab:
                        break;
                }
            }
        }

        /// <summary>
        /// Applies orientated format to the input data tables
        /// </summary>
        private void InputDataFormat()
        {
            //Loop through each DataInput class to collect and format the required sheets
            foreach(DataInput input in DataList)
            {
                //Loop through each sheet input and format them
                foreach(SheetInput sheet in input.Sheets)
                {
                    //Clone the input data
                    sheet.FormattedTable = input.ExcelDataSet.Tables[sheet.SheetName].Copy();

                    RemoveRowsFromEnd(sheet);
                    RemoveRowsFromStart(sheet);
                    RemoveColumnsFromEnd(sheet);
                    RemoveColumnsFromStart(sheet);
                }
            }
        }

        /// <summary>
        /// Remove all rows after the given row number
        /// </summary>
        /// <param name="sheet"></param>
        private static void RemoveRowsFromEnd(SheetInput sheet)
        {
            if (sheet.EndRow > 0)
            {
                // Remove all rows after the given row number
                var rowsToDelete = sheet.FormattedTable.AsEnumerable()
                                            .Skip(sheet.EndRow)  // Skip the first n + 1 rows
                                            .ToList();            // Convert to a list for safe enumeration

                rowsToDelete.ForEach(row => row.Delete());         // Mark rows for deletion

                // Finalize the deletion
                sheet.FormattedTable.AcceptChanges();
            }
        }

        /// <summary>
        /// Remove rows before required start row
        /// </summary>
        /// <param name="sheet"></param>
        private static void RemoveRowsFromStart(SheetInput sheet)
        {
            // Ensure StartRow is within a valid range
            if (sheet.StartRow > 1 && sheet.StartRow <= sheet.FormattedTable.Rows.Count)
            {
                // Loop through the rows to remove rows before StartRow
                for (int i = sheet.StartRow - 2; i >= 0; i--)  // Start from StartRow-2 to remove above rows
                {
                    sheet.FormattedTable.Rows[i].Delete();
                }

                // Commit the changes to the DataTable
                sheet.FormattedTable.AcceptChanges();
            }
        }

        /// <summary>
        /// Remove columns before the target column
        /// </summary>
        /// <param name="sheet"></param>
        private void RemoveColumnsFromStart(SheetInput sheet)
        {
            for (int i = sheet.StartColumn - 1; i > 0; i--)
            {
                sheet.FormattedTable.Columns.RemoveAt(i);
            }
        }

        /// <summary>
        /// Remove columns after a target column
        /// </summary>
        /// <param name="sheet"></param>
        private void RemoveColumnsFromEnd(SheetInput sheet)
        {
            for (int i = sheet.FormattedTable.Columns.Count - 1; i > sheet.EndColumn; i--)
            {
                sheet.FormattedTable.Columns.RemoveAt(i);
            }
        }
    }
}
