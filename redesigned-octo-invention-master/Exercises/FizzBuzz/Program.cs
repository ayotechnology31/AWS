using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Write a loop that outputs the numbers from 1 to 100 in the console.
            //If the number is a multiple of 3, print the word “Fizz” next to the number.
            //If the number is a multiple of 5, print the word “Buzz” next to the number.
            //If it is both, print “FizzBuzz” next to the number.

            Execute();
            Console.ReadLine();
        }

		static void Execute()
		{

			int total = 1;

			for (int numberLoops = 1; numberLoops <= 100; numberLoops++)
			{

				if (numberLoops == 0)
				{
					Console.WriteLine(numberLoops);

				}
				else if (numberLoops % 3 == 0 && numberLoops % 5 == 0)
				{
					Console.WriteLine("{0} fizz buzz", numberLoops);
					total++;
					if (numberLoops == total)
					{
						break;
					}
				}
				else if (numberLoops % 3 == 0)
				{
					Console.WriteLine("{0} fizz", numberLoops);
					total++;
					if (numberLoops == total)
					{
						break;
					}
				}
				else if (numberLoops % 5 == 0)
				{
					Console.WriteLine("{0} buzz", numberLoops);
					total++;
					if (numberLoops == total)
					{
						break;
					}
				}
				else
				{
					Console.WriteLine(numberLoops);
				}
			}
		}
	}
}
