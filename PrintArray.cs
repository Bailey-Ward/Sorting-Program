using System;

namespace Sorting_Program
{
    public class PrintArray
    {
        public void PrintAscending(int[] sharesList)
        {
            int n = sharesList.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(sharesList[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintDescending(int[] sharesList)
        {
            int n = sharesList.Length - 1;

            for (int i = n; i >= 0; i--)
            {
                Console.Write(sharesList[i] + " ");

            }
            Console.WriteLine("\n");

        }
    }
}