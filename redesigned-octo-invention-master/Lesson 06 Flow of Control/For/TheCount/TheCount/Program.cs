using System;

namespace TheCount
{
	class Program
	{
		static void Main(string[] args)
		{
			string start;
			string stop;
			string countBy;
			int startInt;
			int stopInt;
			int countByInt;
			int numberLoops = 0;
		

			Console.WriteLine("*** I LOVE TO COUNT! LET ME SHARE MY COUNTING WITH YOU! ***");
			Console.Write("Start at: ");
			start = Console.ReadLine();
			Console.Write("Stop at: ");
			stop = Console.ReadLine();
			Console.Write("Count by: ");
			countBy = Console.ReadLine();

			if (int.TryParse(start, out startInt))
			{
				if(int.TryParse(stop, out stopInt))
				{
					if (int.TryParse(countBy, out countByInt))
					{
						for (int i = startInt; i < stopInt; i +=countByInt)
						{
							if (stopInt > startInt + countByInt)
							{
								Console.Write(i + " ");
								numberLoops++;
								if (numberLoops == 3)
								{

									Console.Write("Ah, ah, ah!  \n");
								}
								//if(numberLoops == 3)
								//{

								//	Console.Write("Ah, ah, ah");
								//}
								//else
								//{
								//	Console.Write(i + " ");
								//	numberLoops++;
								//}
							}
						}
					}
				}
			}
		
		}
	}
}
