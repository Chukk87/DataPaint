using System.Collections.Generic;

namespace DataPaintLibrary.Classes
{
    public class ReportOutput
    {
        int Id { get; }
        string ReportName { get; set; }
        string Description { get; set; }
        bool AutoGenerate { get; set; }
        string OutputLocation { get; set; }
        List<DataInput> InputData { get; set; }
    }
}