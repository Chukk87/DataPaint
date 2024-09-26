using DataPaintLibrary.Classes.Orientation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPaintLibrary.Classes
{
    public class SheetInput
    {
        public string SheetName;
        public bool IncludeHeader;
        public int StartRow;
        public int EndRow;
        public int StartColumn;
        public int EndColumn;
        public DataTable FormattedTable;
    }
}
 