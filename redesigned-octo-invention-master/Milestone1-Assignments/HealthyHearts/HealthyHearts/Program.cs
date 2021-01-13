using System;

namespace HealthyHearts
{
	class Program
	{
		static void Main(string[] args)
		{
			//Make a simple calculator that asks the user for their age. Then calculate the healthy heart rate range for that age, and display it.
			//Their maximum heart rate should be 220 - their age.
			//The target heart rate zone is the 50 - 85 % of the maximum.

			int output;
			int heartRate;
			double heartRateMin;
			double heartRateMax;

			while (true)
			{
				Console.WriteLine("How old are you? ");
				string input = Console.ReadLine();

				if (int.TryParse(input, out output))
				{
					heartRate = (220 - output);//this is an assignment not equals 

					Console.WriteLine("Your maximum heart rate should be " + heartRate + " beats per minute.");

					heartRateMin = (heartRate * .50);
					heartRateMax = (heartRate * .85);

					Console.WriteLine("Your target HR Zone is " + heartRateMin + " - " + heartRateMax + " beats per minute");
					break;
				}
			}
		}
	}
}
