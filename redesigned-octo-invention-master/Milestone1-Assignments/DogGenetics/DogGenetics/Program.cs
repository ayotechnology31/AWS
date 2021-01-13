using System;

namespace DogGenetics
{
	class Program
	{
		static void Main(string[] args)
		{
			//Write a program that asks the user for the name of their dog, and then generates a fake DNA background report on the pet dog.
			//It should assign a random percentage to 5 dog breeds(that should add up to 100 % !) 

			Random perc = new Random();
			int a = 0, b = 0, c = 0, d = 0, e = 0;
			int total = 100;

			string dogName;
			Console.WriteLine("What is your dog's name?");
			dogName = Console.ReadLine();

			Console.WriteLine("Well then, I have this highly reliable report on {0}'s prestigious background right here.", dogName);

			a = perc.Next(0, total);
			total -= a;

			b = perc.Next(0, total);
			total -= b;

			c = perc.Next(0, total);
			total -= c;

			d = perc.Next(0, total);
			total -= d;

			e = total;

			Console.WriteLine("{0}% St. Bernard ", a);
			Console.WriteLine("{0}% Chihuahua ", b);
			Console.WriteLine("{0}% Dramatic RedNosed Asian Pug ", c);
			Console.WriteLine("{0}% Common Cur ", d);
			Console.WriteLine("{0}% King Doberman ", e);
			Console.WriteLine("Wow, that's QUITE the dog!");
		}
	}
}
