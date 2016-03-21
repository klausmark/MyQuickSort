using System;
using System.Collections.Generic;
using MyQuickSortLib;

namespace UsageExample
{
    internal class Program
    {
        private static void Main()
        {
            const int numberOfElements = 20;

            var unsortedList = GenerateRandomList(numberOfElements);
            var sortedList = unsortedList.QuickSort();

            PrintArray(unsortedList);
            PrintArray(sortedList);
        }

        private static int[] GenerateRandomList(int numberOfElements)
        {
            var random = new Random();
            var unsortedList = new int[numberOfElements];
            for (var i = 0; i < numberOfElements; i++)
                unsortedList[i] = random.Next(0, 10);
            return unsortedList;
        }

        private static void PrintArray<T>(IEnumerable<T> list)
        {
            Console.WriteLine(new ListFormatter<T>(list).GetFormattedList());
        }
    }
}
