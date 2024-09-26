using DataPaintLibrary.Enums;
using System.Collections.Generic;
using System.Data;

namespace DataPaintLibrary.Classes
{
    public class DataInput
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public int OwnerGroupId { get; set; }
        public ExtractionType ExtractionType { get; set; }
        public DataType DataType { get; set; }
        public string Location { get; set; }
        public DataSet ExcelDataSet { get; set; }
        public List<SheetInput> Sheets { get; set; } = new List<SheetInput>();
        public List<string> SheetNameLog { get; set; } = new List<string>();
    }
}
