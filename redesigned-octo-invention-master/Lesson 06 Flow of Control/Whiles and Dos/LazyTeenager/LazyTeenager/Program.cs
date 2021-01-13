using System;

namespace LazyTeenager
{
	class Program
	{
		static void Main(string[] args)
		{
			//Write a program that simulates a lazy teenager who won't clean their room until their parent tells them repeatedly to do it.

			//You should write this in a do/while loop, which continues to execute until the room is clean.

			//Every time the loop executes, the parent should tell the teenager to clean their room. Each time the teenager is told to clean their room, it increases the chance the teenager will clean the room by 5 %.However, by the 15th time, they're going to get grounded and have their xbox confiscated. (Note: Use a break, not a compound condition to stop the loop in that case.)

			//So the first time they're told, there is only a 5% chance they'll clean it.
			//The second time, there's a 10% chance. Use Random to calculate this “chance” check.


			bool cleaned = false;
			int cleaningChance = 0;
			int numberOfTimes = 0;
			//int acceptableChance = 60;
			Random chance = new Random();
			int acceptableChance = chance.Next(70,80);

			do
			{
				Console.Write(cleaningChance + "%" + " ");
				Console.WriteLine("Clean your room!!");
				cleaningChance = cleaningChance + 5;
				numberOfTimes++;
				if(numberOfTimes == 15)
				{
					Console.WriteLine("Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
					break;
				}
				if(cleaningChance >= acceptableChance)
				{
					Console.WriteLine("FINE! I'LL CLEAN MY ROOM. BUT I REFUSE TO EAT MY PEAS");
					cleaned = true;
				}

			}
			while (cleaned == false);



			//Random chance = new Random();
			//int clean = chance.Next(15);

			//Console.Write("Did you clean your room?");
			//bool cleaned;
			
			//if(Console.ReadLine().Equals("y"))
			//{
			//	cleaned = true;
			//}
			//else
			//{
			//	cleaned = false;
			//}

			//bool x = false;
			//do
			//{
			//	x = true;
			//	break;
			//} while (cleaned);

			//if(clean*5 != cleaned)
			//{
			//	Console.WriteLine("Clean your room!!");
			//}
			//else
			//{
			//	Console.WriteLine("Clean your room!! That's IT, I'm doing it!!! YOU'RE GROUNDED AND I'M TAKING YOUR XBOX!");
			//}
		}
	}
}
