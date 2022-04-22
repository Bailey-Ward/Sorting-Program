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
            int[] reverseArray;


            while (true)
            {
                Console.WriteLine("Type 1 to select bubble sort:\nType 2 to select merge sort:\nType 3 to select quick sort:\nType 4 to exit the program:\n");
                string choice = Console.ReadLine();
                Console.WriteLine("Type 1 to sort share 1:\nType 2 to sort share 2:\nType 3 to sort share 3:\n");
                string shareChoice = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------------------");
                if (choice == "1")
                {

                    if (shareChoice == "1")
                    {
                        emptyArray = share.SharesFiles_1_256();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintDescending(emptyArray);
                        Console.WriteLine("What number would you like to search for in the sorted array?\n");
                        int number = int.Parse(Console.ReadLine());
                        var index = Search.BinarySearch(emptyArray, number);
                        Console.WriteLine("Index {0} in the array.", index);
                    }
                    else if (shareChoice == "2")
                    {
                        emptyArray = share.SharesFiles_2_256();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        int number = int.Parse(Console.ReadLine());
                        var index = Search.BinarySearch(emptyArray, number);
                        Console.WriteLine("Index {0} in the array.", index);
                    }
                    else if (shareChoice == "3")
                    {
                        emptyArray = share.SharesFiles_3_256();
                        sort.BubbleSort(emptyArray);
                        Console.WriteLine("Type 1 for ascending order:\nType 2 for descending order:\n");
                        string viewChoice = Console.ReadLine();
                        if (viewChoice == "1")
                        {
                            printArray.PrintAscending(emptyArray);
                        }
                        else if (viewChoice == "2")
                        {
                            printArray.PrintDescending(emptyArray);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            break;
                        }
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            var index = Search.BinarySearch(emptyArray, number);
                            Console.WriteLine("Index {0} in the array.", index);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                        continue;
                    }
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
