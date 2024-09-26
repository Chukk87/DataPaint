using System.Data;

namespace DataPaintLibrary.Classes
{
    public class SheetInput
    {
        /// <summary>
        /// Gets or sets the name of the sheet.
        /// </summary>
        public string SheetName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the sheet includes a header.
        /// </summary>
        public bool IncludeHeader { get; set; }

        /// <summary>
        /// Gets or sets the starting row for the data in the sheet.
        /// </summary>
        public int StartRow { get; set; }

        /// <summary>
        /// Gets or sets the ending row for the data in the sheet.
        /// </summary>
        public int EndRow { get; set; }

        /// <summary>
        /// Gets or sets the starting column for the data in the sheet.
        /// </summary>
        public int StartColumn { get; set; }

        /// <summary>
        /// Gets or sets the ending column for the data in the sheet.
        /// </summary>
        public int EndColumn { get; set; }

        /// <summary>
        /// Gets or sets the formatted data table for the sheet.
        /// </summary>
        public DataTable FormattedTable { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SheetInput"/> class.
        /// </summary>
        public SheetInput(string sheetName, bool includeHeader, int startRow, int endRow, int startColumn, int endColumn)
        {
            SheetName = sheetName;
            IncludeHeader = includeHeader;
            StartRow = startRow;
            EndRow = endRow;
            StartColumn = startColumn;
            EndColumn = endColumn;
            FormattedTable = new DataTable(); // Initialize FormattedTable as a new DataTable
        }

        /// <summary>
        /// Returns a string representation of the SheetInput object.
        /// </summary>
        /// <returns>A string that represents the current <see cref="SheetInput"/> object.</returns>
        public override string ToString()
        {
            return $"SheetInput: {SheetName}, IncludeHeader: {IncludeHeader}, StartRow: {StartRow}, EndRow: {EndRow}, StartColumn: {StartColumn}, EndColumn: {EndColumn}";
        }
    }
}