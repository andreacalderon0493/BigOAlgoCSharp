using System;
namespace BigOAlgo
{
	public class Algorithm
	{
		public Algorithm()
		{
			
		}

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
	}
}

