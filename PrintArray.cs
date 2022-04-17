using System;

namespace Sorting_Program
{
    public class PrintArray
    {
        public void Print(int[] sharesList)
        {
            int n = sharesList.Length;
            for (int i = 0; i < n; i++)
                Console.Write(sharesList[i]+ " ");
            Console.WriteLine();
        }
    }
}