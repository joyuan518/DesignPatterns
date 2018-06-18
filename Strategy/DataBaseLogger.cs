using System;

namespace DesignPatterns.Strategy
{
    public class DataBaseLogger : ILogger
    {
        void ILogger.WriteError(Exception ex)
        {
            //Write error info into database
            throw new NotImplementedException();
        }

        void ILogger.WriteInfo(string message)
        {
            //Write into into database
            throw new NotImplementedException();
        }
    }
}