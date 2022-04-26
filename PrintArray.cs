using System;

namespace Sorting_Program
{
    public class PrintArray
    {
        public void PrintAscending256(int[] sharesList)
        {
            int n = sharesList.Length;
            Console.WriteLine("10th values sorted ascending:");
            for (int i = 9; i < n; i += 10)
            {
                Console.Write(sharesList[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintDescending256(int[] sharesList)
        {
            int n = sharesList.Length;
            Console.WriteLine("10th values sorted descending:");
            for (int i = n-9; i >= 0; i -= 10)
            {
                Console.Write(sharesList[i] + " ");

            }
            Console.WriteLine("\n");

        }

        public void PrintAscending2048(int[] shareList)
        {
            int n = shareList.Length;
            Console.WriteLine("50th values sorted ascending:");
            for (int i = 49;i < n; i += 50)
            {
                Console.Write(shareList[i] + " ");

            }
            Console.WriteLine("\n");
        }

        public void PrintDescending2048(int[] shareList)
        {
            int n = shareList.Length;
            Console.WriteLine("50th values sorted descending:");
            for (int i = n- 49; i >= n; i -= 50)
            {
                Console.Write(shareList[i] + " ");

            }
            Console.WriteLine("\n");
        }
    }
}