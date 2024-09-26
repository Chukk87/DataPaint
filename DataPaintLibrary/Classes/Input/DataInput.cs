using DataPaintLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Classes
{
    public class DataInput
    {
        public ExtractionType ExtractionType { get; set; }
        public DataType DataType { get; set; }
        public string Location { get; set; }
        public int Security { get; set; }
        public DataSet ExcelDataSet { get; set; }
        public List<SheetInput> Sheets { get; set; } = new List<SheetInput>();
        public List<string> SheetNameLog { get; set; } = new List<string>();
    }
}
