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
			string newpath = Path.GetFullPath(Path.Combine(path, @"..\..\","Share_1_256.txt"));
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