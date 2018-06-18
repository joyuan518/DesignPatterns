using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class Client
    {
        public static void Run()
        {
            var sorttedListPrinter = new SorttedListPrinter<int>(new FastSortter<int>(),
                                                                 (i, j) => i > j, 
                                                                 new FileLogger(),
                                                                 i => i.ToString());

            sorttedListPrinter.Print(new List<int> { 10, 8, 9, 2, 3, 7, 1, 0});
        }
    }
}