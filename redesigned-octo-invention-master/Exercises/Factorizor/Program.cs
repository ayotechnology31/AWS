using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumberFromUser();

			Calculator.PrintFactors(number);
            Calculator.IsPerfectNumber(number);
            Calculator.IsPrimeNumber(number);

            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompt the user for an integer.  Make sure they enter a valid integer!
        /// 
        /// See the String Input lesson for TryParse() examples
        /// </summary>
        /// <returns>the user input as an integer</returns>
        static int GetNumberFromUser()
        {
			int output;
			while (true)
			{
				Console.WriteLine("What number would you like to factor? ");
				string input = Console.ReadLine();

				if (int.TryParse(input, out output))
				{
                    return output; 
				}
				else
				{
					Console.WriteLine("That was not a whole number!");
				}
			}

			throw new NotImplementedException();
        }
    }

    class Calculator
    {
        /// <summary>
        /// Given a number, print the factors per the specification
        /// </summary>
        public static void PrintFactors(int number)
        {
			int x;
			Console.WriteLine("The Factors are : ");
			for (x = 1; x <= number; x++)
			{
				if (number % x == 0)
				{
					Console.WriteLine(x);
				}
			}
		}

        /// <summary>
        /// Given a number, print if it is perfect or not
        /// </summary>
        public static void IsPerfectNumber(int number)
        {
            int sum = 0, n;

            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("{0} is a perfect number", number);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} number is not a perfect number", number);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Given a number, print if it is prime or not
        /// </summary>
        public static void IsPrimeNumber(int number)
        {
            int i, m = 0, flag = 0;
            m = number / 2;

            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("{0} is not prime number.", number);
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                Console.Write("{0} is prime number.", number);
        }
    }
}
