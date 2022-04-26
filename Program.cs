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
                Console.WriteLine("Type 1 to select bubble sort:\nType 2 to select insertion sort:\nType 3 to exit the program:\n");
                string choice = Console.ReadLine();
                Console.WriteLine("Type 1 to sort share_1_256.txt:\nType 2 to sort share_2_256.txt:\nType 3 to sort share_3_256.txt:\nType 4 to sort share_1_2048.txt:\nType 5 to sort share_2_2048.txt:\nType 6 to sort share_3_2048.txt:");
                string shareChoice = Console.ReadLine();
                Console.WriteLine("------------------------------------------------------------------------------------");
                if (choice == "1")
                {

                    if (shareChoice == "1")
                    {
                        emptyArray = share.SharesFiles_1_256();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending256(emptyArray);
                        printArray.PrintDescending256(emptyArray);
                        Console.WriteLine("What number would you like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }
                    }
                    else if (shareChoice == "2")
                    {
                        emptyArray = share.SharesFiles_2_256();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending256(emptyArray);
                        printArray.PrintDescending256(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }
                    }
                    else if (shareChoice == "3")
                    {
                        emptyArray = share.SharesFiles_3_256();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending256(emptyArray);
                        printArray.PrintDescending256(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }

                    }
                    else if (shareChoice == "4")
                    {
                        emptyArray = share.SharesFiles_1_2048();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending2048(emptyArray);
                        printArray.PrintDescending2048(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }

                    }
                    else if (shareChoice == "5")
                    {
                        emptyArray = share.SharesFiles_2_2048();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending2048(emptyArray);
                        printArray.PrintDescending2048(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }

                    }
                    else if (shareChoice == "6")
                    {
                        emptyArray = share.SharesFiles_3_2048();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending2048(emptyArray);
                        printArray.PrintDescending2048(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
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
                    if (shareChoice == "1")
                    {
                        emptyArray = share.SharesFiles_1_256();
                        sort.InsertionSort(emptyArray);
                        printArray.PrintAscending256(emptyArray);
                        printArray.PrintDescending256(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }
                    }
                    else if (shareChoice == "2")
                    {
                        emptyArray = share.SharesFiles_2_256();
                        sort.InsertionSort(emptyArray);
                        printArray.PrintAscending256(emptyArray);
                        printArray.PrintDescending256(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }
                    }
                    else if (shareChoice == "3")
                    {
                        emptyArray = share.SharesFiles_3_256();
                        sort.InsertionSort(emptyArray);
                        printArray.PrintAscending256(emptyArray);
                        printArray.PrintDescending256(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                            {
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }
                    }
                    else if (shareChoice == "4")
                    {
                        emptyArray = share.SharesFiles_1_2048();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending2048(emptyArray);
                        printArray.PrintDescending2048(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }

                    }
                    else if (shareChoice == "5")
                    {
                        emptyArray = share.SharesFiles_2_2048();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending2048(emptyArray);
                        printArray.PrintDescending2048(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }

                    }
                    else if (shareChoice == "6")
                    {
                        emptyArray = share.SharesFiles_3_2048();
                        sort.BubbleSort(emptyArray);
                        printArray.PrintAscending2048(emptyArray);
                        printArray.PrintDescending2048(emptyArray);
                        Console.WriteLine("Input the number you would like to search for in the sorted array?\n");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------------------");
                            var index = Search.BinarySearch(emptyArray, number);
                            foreach (int i in index)
                                if (i == -1)
                                {
                                    Console.WriteLine("Number does not exist in the array.");
                                }
                                else
                                {
                                    Console.WriteLine("Appears at index {0} in the array.", i);
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("This is not a number");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    break ;
                }
                else if (choice == "3")
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
