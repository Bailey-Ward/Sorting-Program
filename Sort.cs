using System;

namespace Sorting_Program
{
    public class Sort
    {
        public int BubbleSort(int[] sharesArray)
        {
            int counter = 0;
            int n = sharesArray.Length;
            for (int i = 0; i < n - 1; i++)
                for(int j = 0; j < n - i - 1; j++)
                    if(sharesArray[j] > sharesArray[j + 1])
                    {
                        (sharesArray[j + 1], sharesArray[j]) = (sharesArray[j], sharesArray[j + 1]);
                        counter++;
                    }
            Console.WriteLine($"Turns taken to bubble sort this array: {counter}");
            Console.WriteLine("\n");
            return counter;
        }

        public int MergeSort(int[] sharesArray)
        {
            return 2;
        }
    }
}