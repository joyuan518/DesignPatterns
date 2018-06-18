using System.Collections.Generic;
using System;

namespace DesignPatterns.Strategy
{
    public interface ISortter<T> where T : struct
    {
         List<T> Sort(List<T> list, Func<T, T, bool> comparator);
    }
}