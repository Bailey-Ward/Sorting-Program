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
                Console.WriteLine("Type 1 to select bubble sort:\nType 2 to select merge sort:\nType 3 to select quick sort:\nType 4 to exit the program:\n");
                string choice = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------------------");
                if (choice == "1")
                {
                    emptyArray = share.SharesFiles_1_256();
                    sort.BubbleSort(emptyArray);
                    printArray.Print(emptyArray);
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
            Console.ReadLine();


        }
    }
}
