using System;

namespace TwoForsAndTenYearsAgo
{
	class Program
	{
		static void Main(string[] args)
		{

            ////Type out the following code! Make it work!
            ////What are the ranges for the starting/ stopping in both for loops ? (answer in a comment!) int i = 0; i <= 10
            ///
            ////Which one is clearer to you? Why? (Answer in another comment!) first loop makes sense. It assigns the year. Then it declares i variable sa times to loop. The says i variable is number times
            ///to loop plus " years ago would be " plus (year - number times it looped)
            ///
            ////Change it so that the second loop counts back twenty years.
            ///
            Console.WriteLine("What year would you like to count back from? ");

            int year = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + " years ago would be " + (year - i));
            }

            //Console.WriteLine("\nI can count backwards using a different way too...");

            //for (int i = year; i >= year - 10; i--)
            //{
            //    Console.WriteLine((year - i) + " years ago would be " + i);
            //}

            ///updating second loop
            Console.WriteLine("\nI can count backwards using a different way too...");

            for (int i = year; i >= year - 20; i--)
            {
                Console.WriteLine((year - i) + " years ago would be " + i);
            }

            //if reduce by 20 years??
            for (int i = year; i >= year - 200; i = i-20)
            {
                Console.WriteLine((year - i) + " years ago would be " + i);
            }
        }
	}
}
