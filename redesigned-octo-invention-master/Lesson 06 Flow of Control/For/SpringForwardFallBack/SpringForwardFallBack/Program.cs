using System;

namespace SpringForwardFallBack
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("It's Spring...!");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("\nOh no, it's fall...");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + ", ");
            }
            ///What are the start/stop ranges of output for both loops? (answer in a comment!)
            ///start and stop are the i++ and i--
            ///Update loop #1 so that it prints out the same range as loop #2, but only change the start or stopping points
            Console.WriteLine("It's Spring...!");
            for (int i = 0; i < 10; i--)
            {
                Console.Write(i + ", ");
            }
        }
	}
}
