using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class SorttedListPrinter<T> where T : struct
    {
        protected readonly ISortter<T> _sortter;
        protected readonly Func<T, T, bool> _comparator;
        protected readonly ILogger _logger;
        protected readonly Func<T, string> _formatter;

        public SorttedListPrinter(ISortter<T> sortter, Func<T, T, bool> comparator, 
                                    ILogger logger, Func<T, string> formatter)
        {
            //Here the constructor accept several implementations of 
            //strategy interfaces and strategy delegates
            _sortter = sortter;
            _comparator = comparator;
            _logger = logger;
            _formatter = formatter;
        }

        public void Print(List<T> list)
        {
            try
            {
                _logger.WriteInfo("Print started...");

                _sortter.Sort(list, _comparator).ForEach(i => Console.WriteLine(_formatter(i)));

                _logger.WriteInfo("Print completed.");
            }
            catch (Exception ex)
            {
                _logger.WriteError(ex);
                throw;
            }
        }
    }
}