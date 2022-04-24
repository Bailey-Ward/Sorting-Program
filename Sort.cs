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

        public void InsertionSort(int[] sharesArray)
        {
            int swaps = 0;
            int comparisons = 0;
            int n = sharesArray.Length;
            for (int i = 0; i < n - 1; i++)
            {
                comparisons++;
                int key = sharesArray[i];
                int j = i - 1;

                while (j >= 0 && sharesArray[j] > key)
                {
                    sharesArray[j + 1] = sharesArray[j];
                    j--;
                    swaps++;
                }
                sharesArray[j + 1] = key;
            }
            Console.WriteLine("Number of swaps performed:{0} ", swaps);
            Console.WriteLine("Number of comparisons made:{0} ", comparisons);
        }
    }
}