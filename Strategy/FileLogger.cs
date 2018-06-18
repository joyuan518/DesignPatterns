using System;

namespace DesignPatterns.Strategy
{
    public class FileLogger : ILogger
    {
        void ILogger.WriteError(Exception ex)
        {
            //Write error info into log file
            throw new NotImplementedException();
        }

        void ILogger.WriteInfo(string message)
        {
            //Write info into log file
            throw new NotImplementedException();
        }
    }
}