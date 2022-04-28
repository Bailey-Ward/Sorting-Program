using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Program
{
	public class Share
	{
		public int[] SharesFiles_1_256()
		{

			string path = Directory.GetCurrentDirectory();
			string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\","Share_1_256.txt")); //sets directory and name for files to be read from
			List<int> sharesList = new List<int>(); //list for storing values
			string[] readFile = File.ReadAllLines(newpath);
			foreach (string line in readFile) //reads each line in the file
            {
                try
                {
					sharesList.Add(int.Parse(line)); //parses each line into an integer and adds it to the list
					
                }
				catch (FormatException) //error in case line cannot be parsed
                {
					Console.WriteLine("Unable to convert line.");
                }
                catch (OverflowException) //error handling in case value is out of range
                {
					Console.WriteLine("Value out of int32 type range.");
                }
            }
			int[] sharesArray = sharesList.ToArray(); //turns list into an array
			return sharesArray; //returns the array
		}

		public int[] SharesFiles_2_256()
		{
			string path = Directory.GetCurrentDirectory();
			string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\","Share_2_256.txt"));
			List<int> sharesList = new List<int>();
			string[] readFile = File.ReadAllLines(newpath);
			foreach (string line in readFile)
            {
                try
                {
					sharesList.Add(int.Parse(line));
					
                }
				catch (FormatException)
                {
					Console.WriteLine("Unable to convert line.");
                }
                catch (OverflowException)
                {
					Console.WriteLine("Value out of int32 type range.");
                }
            }
			int[] sharesArray = sharesList.ToArray();
			return sharesArray;
		}

		public int[] SharesFiles_3_256()
		{
			string path = Directory.GetCurrentDirectory();
			string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\","Share_3_256.txt"));
			List<int> sharesList = new List<int>();
			string[] readFile = File.ReadAllLines(newpath);
			foreach (string line in readFile)
            {
                try
                {
					sharesList.Add(int.Parse(line));
					
                }
				catch (FormatException)
                {
					Console.WriteLine("Unable to convert line.");
                }
                catch (OverflowException)
                {
					Console.WriteLine("Value out of int32 type range.");
                }
            }
			int[] sharesArray = sharesList.ToArray();
			return sharesArray;
		}

		public int[] SharesFiles_1_2048()
		{
			string path = Directory.GetCurrentDirectory();
			string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\", "Share_1_2048.txt"));
			List<int> sharesList = new List<int>();
			string[] readFile = File.ReadAllLines(newpath);
			foreach (string line in readFile)
			{
				try
				{
					sharesList.Add(int.Parse(line));

				}
				catch (FormatException)
				{
					Console.WriteLine("Unable to convert line.");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Value out of int32 type range.");
				}
			}
			int[] sharesArray = sharesList.ToArray();
			return sharesArray;
		}

		public int[] SharesFiles_2_2048()
		{
			string path = Directory.GetCurrentDirectory();
			string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\", "Share_2_2048.txt"));
			List<int> sharesList = new List<int>();
			string[] readFile = File.ReadAllLines(newpath);
			foreach (string line in readFile)
			{
				try
				{
					sharesList.Add(int.Parse(line));

				}
				catch (FormatException)
				{
					Console.WriteLine("Unable to convert line.");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Value out of int32 type range.");
				}
			}
			int[] sharesArray = sharesList.ToArray();
			return sharesArray;
		}

		public int[] SharesFiles_3_2048()
		{
			string path = Directory.GetCurrentDirectory();
			string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\", "Share_3_2048.txt"));
			List<int> sharesList = new List<int>();
			string[] readFile = File.ReadAllLines(newpath);
			foreach (string line in readFile)
			{
				try
				{
					sharesList.Add(int.Parse(line));

				}
				catch (FormatException)
				{
					Console.WriteLine("Unable to convert line.");
				}
				catch (OverflowException)
				{
					Console.WriteLine("Value out of int32 type range.");
				}
			}
			int[] sharesArray = sharesList.ToArray();
			return sharesArray;
		}
	}
}