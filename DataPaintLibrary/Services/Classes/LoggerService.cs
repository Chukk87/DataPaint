using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using DataPaintLibrary.Services.Interfaces;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Classes
{
    public class LoggerService : ILoggerService
    {
        private int _currentIncrement = 1;
        private ConcurrentBag<Log> _log = new ConcurrentBag<Log>();

        public void RecordException(Exception exception, string method, string otherDetail)
        {
            Log newLog = new Log()
            {
                Increment = _currentIncrement,
                MethodSource = method,
                ObjectSource = exception.Source,
                ExceptionDetail = exception,
                OtherDetail = otherDetail
            };

            _currentIncrement++;
            _log.Add(newLog);
        }

        public void RecordException(Exception exception, string method)
        {
            RecordException(exception, method, string.Empty);
        }

        public void LogInfo(string message, string method)
        {
            Log newLog = new Log()
            {
                Increment = _currentIncrement,
                MethodSource = method,
                ObjectSource = "Info",
                ExceptionDetail = null,
                OtherDetail = message
            };

            _currentIncrement++;
            _log.Add(newLog);
        }

        public IEnumerable<Log> GetLogs()
        {
            return _log;
        }
    }
}