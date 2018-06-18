using System;

namespace DesignPatterns.Strategy
{
    public interface ILogger
    {
         void WriteInfo(string message);

         void WriteError(Exception ex);
    }
}