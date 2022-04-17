using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Program
{
    class Program
    {
        static void Main()
        {
            PrintArray printArray = new PrintArray();
            Share share = new Share();
            Sort sort = new Sort();
            int[] emptyArray;



            while (true)
            {
                Console.WriteLine("Type 1 to select bubble sort:\n Type 2 to select merge sort:\n Type 3 to select quick sort:\n Type 4 to exit the program:");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    emptyArray = share.SharesFiles();
                    sort.BubbleSort(emptyArray);
              
                    
                    break;
                }
                else if (choice == "2")
                {
                    break;
                }
                else if (choice == "3")
                {
                    break;
                }
                else if (choice == "4")
                {
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

            }
            printArray.Print(emptyArray);

        }
    }
}
