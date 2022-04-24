using System;

namespace Sorting_Program
{
    public class Search
    {        
      public static object BinarySearch(int[] sharesArray, int number)
        {
            int counter = 0;
            int start = 0;
            int end = sharesArray.Length - 1;

            while (start < end)
            {
                int middle = (start + end) / 2;
                if (number == sharesArray[middle])
                {
                    counter++;
                    Console.WriteLine("Comparisons made: {0}", counter);
                    Console.WriteLine("\n");
                    return middle;
                }
                else if (number < sharesArray[middle])
                {
                    counter++;
                    end = middle - 1;
                }
                else
                {
                    counter++;
                    start = middle + 1;
                }
                
            }
            return "could not be found";
        }
    }
} 

       /* public static object ReverseBinarySearch(int[] sharesArray, int number )
        {
            int start = 0;
            int end = sharesArray.Length - 1;

            while ( start < end )
            {
                int middle = start + (end - start) / 2;
                if( number == sharesArray[middle])
                {
                    return middle;
                }
                else if ( number < sharesArray[middle])
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }
            return "could not be found";
        }

    }
} */
       