using System;
using System.Collections.Generic;
using DataPaintLibrary.Classes;

namespace DataPaintLibrary.Services.Interfaces
{
    public interface ILoggerService
    {
        /// <summary>
        /// Records an exception with additional details
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="method"></param>
        /// <param name="otherDetail"></param>
        void RecordException(Exception exception, string method, string otherDetail);
        /// <summary>
        /// Records an exception
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="method"></param>
        void RecordException(Exception exception, string method);
        /// <summary>
        /// Records a message
        /// </summary>
        /// <param name="message"></param>
        /// <param name="method"></param>
        void LogInfo(string message, string method);
        /// <summary>
        /// Lists active log
        /// </summary>
        /// <returns></returns>
        IEnumerable<Log> GetLogs();
    }
}