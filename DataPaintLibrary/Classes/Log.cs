using System;

namespace DataPaintLibrary.Classes
{
    public class Log
    {
        public int Increment { get; set; }
        public string MethodSource { get; set; }
        public string ObjectSource { get; set; }
        public Exception ExceptionDetail { get; set; } 
        public string OtherDetail { get; set; }
    }
}
