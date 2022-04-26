using System;
using System.Collections.Generic;

namespace Sorting_Program
{
    public class Search
    {        
      public static List<int> BinarySearch(int[] sharesArray, int number)
        {
            int counter = 0; //variable for counting the amount of comparisons
            int start = 0; //variable for setting the start position of the array
            int end = sharesArray.Length - 1; //variable for setting the end position of the array
            List<int> indexs = new List<int>();

            while (start < end)
            {
                int middle = (start + end) / 2; //variable for setting middle position
                if (number == sharesArray[middle])  //compares the number searched for with the middle position
                {
                    int i = middle - 1;

                    do
                    {
                        counter++; //increments the counter
                        indexs.Add(middle);
                        middle++;

                    } while (sharesArray[middle] == number); //checks to the left and the right of the number to search for duplicates
                    while (sharesArray[i] == number)
                    {
                        counter++;
                        indexs.Add(i);
                        i--;
                    }
                    Console.WriteLine("Comparisons made: {0}", counter);
                    Console.WriteLine("\n");
                    return indexs; //when number searched for is the same as the middle number, the index is returned
                }
                else if (number < sharesArray[middle])
                {
                    counter++;
                    end = middle - 1; //if number is less than the middle position, middle is moved to the left
                }
                else
                {
                    counter++;
                    start = middle + 1; //if number is more than the middle position, middle is moved to the right
                }
            }
            indexs.Add(-1);
            return indexs; //otherwise method returns -1 which results in a 'not found in array' when method is called
        }
    }
} 
       