using System;

namespace Sorting_Program
{
    public class PrintArray
    {
        public void PrintAscending(int[] sharesList)
        {
            int n = sharesList.Length;
            Console.WriteLine("10th values sorted ascending:");
            for (int i = 9; i < n; i += 10)
            {
                Console.Write(sharesList[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintDescending(int[] sharesList)
        {
            int n = sharesList.Length;
            Console.WriteLine("10th values sorted descending:");
            for (int i = n-9; i >= 0; i -= 10)
            {
                Console.Write(sharesList[i] + " ");

            }
            Console.WriteLine("\n");

        }
    }
}