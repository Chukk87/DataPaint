using System;
using System.Collections.Generic;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ILoggerService
    {
        void RecordException(Exception exception, string method, string otherDetail);
        void RecordException(Exception exception, string method);
        void LogInfo(string message, string method);
        IEnumerable<Log> GetLogs();
    }
}