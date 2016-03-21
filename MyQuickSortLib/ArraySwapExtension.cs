namespace MyQuickSortLib
{
    public static class ArraySwapExtension
    {
        public static void SwapItems<T>(this T[] list, int pos1, int pos2)
        {
            var tmp = list[pos1];
            list[pos1] = list[pos2];
            list[pos2] = tmp;
        }
    }
}