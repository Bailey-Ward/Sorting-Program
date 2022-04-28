using System;

namespace Sorting_Program
{
    public class Sort
    {
        public int BubbleSort(int[] sharesArray)
        {
            int counter = 0; //sets counter to 0
            int n = sharesArray.Length; //sets length of array
            for (int i = 0; i < n - 1; i++) //iterates through the list
                for(int j = 0; j < n - i - 1; j++)
                    if(sharesArray[j] > sharesArray[j + 1]) //adjacent elements are compared
                    {
                        (sharesArray[j + 1], sharesArray[j]) = (sharesArray[j], sharesArray[j + 1]); //if right element is greater than left element positions are swapped
                        counter++; //counter is incremented
                    }
            Console.WriteLine($"Turns taken to bubble sort this array: {counter}");
            Console.WriteLine("\n");
            return counter;
        }

        public void InsertionSort(int[] sharesArray)
        {
            int swaps = 0;
            int comparisons = 0;
            int n = sharesArray.Length; //sets array length
            for (int i = 0; i < n - 1; i++) //for each item in the list
            {
                comparisons++;
                int key = sharesArray[i]; //key is the current position in the array
                int j = i - 1; //j is the left of the current position

                while (j >= 0 && sharesArray[j] > key) //while j is greater than or equal to 0 and the left position is greater than the right position 
                {
                    sharesArray[j + 1] = sharesArray[j]; //j takes position of the greater value
                    j--; //j is continuously moved to the left until it is no longer greater than the value to its right
                    swaps++;
                }
                sharesArray[j + 1] = key; //key moves to the right
            }
            Console.WriteLine("Number of swaps performed:{0} ", swaps);
            Console.WriteLine("Number of comparisons made:{0} ", comparisons);
        }
    }
}