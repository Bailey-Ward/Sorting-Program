using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Program
{
	public class Share
	{
		int[] sharesList = new shareList[] { };
		string strShares = "";
		int intShares;

		public List<string> Shares()
		{
			try
			{
				string strShares = File.ReadAllText("Share_1_256.txt")
				bool isParsable = int32.TryParse(strShares, out intShares);

				if 
					{
					(isParsable)
						this.sharesList.Add(intshares);
					return sharesList;
				}

				else
					{ 
					Console.WriteLine("Could not be parsed.");
					}
			}
			catch
            {
				Console.WriteLine("File could not be found");
				Environment.Exit(0);
				return null;
            }
		}
	}
}