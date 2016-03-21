using System;

namespace MyQuickSortLib
{
    public class QuickSort
    {
        public void Sort<T>(T[] list, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi) return;
            var partition = Partition(list, lo, hi);
            Sort(list, lo, partition - 1);
            Sort(list, partition + 1, hi);
        }

        public void Sort<T>(T[] list) where T : IComparable<T>
        {
            Sort(list, 0, list.Length - 1);
        }

        private int Partition<T>(T[] list, int lo, int hi) where T : IComparable<T>
        {
            var pivot = list[hi];
            var i = lo;
            for (var j = lo; j < hi; j++)
            {
                if (list[j].CompareTo(pivot) > 0) continue;
                list.SwapItems(i, j);
                i++;
            }
            list.SwapItems(i, hi);
            return i;
        }
    }
}