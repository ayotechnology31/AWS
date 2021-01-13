using System;

namespace RollerCoaster
{
	class Program
	{
		static void Main(string[] args)
		{
			//Type in the code below, make it work!
			//What happens if we change the condition to check for a "no" instead ?
			//(To do this, comment out the old condition, and write a new one!)
			//Why is there no int in front of "loopsLooped" when we assign it value ?
			//(Answer in a comment)

			/////original
			//Console.WriteLine("We're going to go on a roller coaster...");
			//Console.WriteLine("Let me know when you want to get off...!");

			//String keepRiding = "y";
			//int loopsLooped = 0;
			//while (keepRiding.Equals("y"))
			//{
			//	Console.WriteLine("WHEEEEEEEEEEEEEeEeEEEEeEeeee.....!!!");
			//	Console.Write("Want to keep going? (y/n) :");
			//	keepRiding = Console.ReadLine();
			//	loopsLooped++;
			//}

			//Console.WriteLine("Wow, that was FUN!");
			//Console.WriteLine("We looped that loop " + loopsLooped + " times!!");


			//What happens if we change the condition to check for a "no" instead?
			//(To do this, comment out the old condition, and write a new one!)

			Console.WriteLine("We're going to go on a roller coaster...");
			Console.WriteLine("Let me know when you want to get off...!");

			String keepRiding = "n";
			int loopsLooped = 0;
			while (keepRiding.Equals("n"))
			{
				Console.WriteLine("WHEEEEEEEEEEEEEeEeEEEEeEeeee.....!!!");
				Console.Write("Want to keep going? (y/n): ");
				keepRiding = Console.ReadLine();
				loopsLooped++;
			}

			Console.WriteLine("I needed to get off the ride");
			Console.WriteLine("We looped that loop " + loopsLooped + " times!!");
		}
	}
}
