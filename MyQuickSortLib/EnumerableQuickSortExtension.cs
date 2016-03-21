using System;
using System.Collections.Generic;
using System.Linq;

namespace MyQuickSortLib
{
    public static class EnumerableQuickSortExtension
    {
        public static IEnumerable<T> QuickSort<T>(this IEnumerable<T> unsortedList) where T : IComparable<T>
        {
            var sortedList = unsortedList.ToArray();
            new QuickSort().Sort(sortedList);
            return sortedList;
        }
    }
}