using System;
namespace BigOAlgo
{
	public class Algorithm
	{
		public Algorithm()
		{

		}
		//Time Complexity is Constant 
		public static bool GetNumber(int number)
		{

			if (number % 2 == 0)
			{
				Console.WriteLine($"{number} is even");
				return true;
			}
			else
			{
				Console.WriteLine($"{number} is odd");
				return false;
			}
		}
		//Task 2 Less Than 100
		// Time Complexity is Linear 
		public static bool DetermineItems(List<int> fullList)

		{
			foreach (int number in fullList)
			{
				if (number >= 100)
				{
					return false;
				}
				else
				{

				}
				
			} return true;
        }

	}
}

