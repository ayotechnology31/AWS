using System;

namespace ConsoleReadLine
{
	class Program
	{
		static void Main(string[] args)
		{
            /////Console.ReadLine() example
            //string requiredString;

            //while (true)
            //{
            //    Console.Write("Enter some data: ");
            //    requiredString = Console.ReadLine();

            //    if (string.IsNullOrEmpty(requiredString))
            //    {
            //        // user hit enter without any data
            //        // display error message then back to top of loop
            //        Console.WriteLine("You did not enter anything!");
            //    }
            //    else
            //    {
            //        // user entered something, leave the loop
            //        break;
            //    }
            //}

            /////Parse() example
            //string userInput = Console.ReadLine();

            //int number = int.Parse(userInput);


            ////TryParse() example
            int output; // storage for converted string

            // infinite loop
            while (true)
            {
                Console.Write("Enter a whole number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out output))
                {
                    break; // output has value
                }
                else
                {
                    Console.WriteLine("That was not a whole number!");
                }
            }

            /////TryParse() example 2
            //int output; // storage for converted string

            //// infinite loop
            //while (true)
            //{
            //    Console.Write("Enter a number between 1 and 10: ");
            //    string input = Console.ReadLine();

            //    if (int.TryParse(input, out output))
            //    {
            //        // it was an int, now is it between 1 and 10?
            //        if (output >= 1 && output <= 10)
            //        {
            //            break; // good input
            //        }
            //        else
            //        {
            //            Console.WriteLine("That number was not between 1 and 10!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("That was not a number!");
            //    }
            //}
        }
    }
}
