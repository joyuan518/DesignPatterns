using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class BubbleSortter<T> : ISortter<T> where T : struct
    {
        List<T> ISortter<T>.Sort(List<T> list, Func<T, T, bool> comparator)
        {
            //Do the sorting and return the sortted list.
            throw new NotImplementedException();            
        }
    }
}