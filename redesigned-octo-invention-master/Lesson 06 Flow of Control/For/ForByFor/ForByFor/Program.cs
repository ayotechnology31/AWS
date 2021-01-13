using System;

namespace ForByFor
{
	class Program
	{
		static void Main(string[] args)
		{

            //For loops are great. But you know what's even GREATER? Loops WITHIN Loops.
            //That's right. NESTED for loops! With ASCII Art!

            //Type out the following code, make it work!
            //Change the code so that the middle column is made of $, the middle row is made of @ and the very center is made of #.

            ////original
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("|");

            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.Write("|");
            //    }
            //    Console.WriteLine("");
            //}

            ////updated
            

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("i is = {0}", i);
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("j is = {0},", j);
            //    }
            //}

            for (int i = 0; i < 3; i++)
            {
                Console.Write("$");

                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("@");
                    }
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
        }
	}
}
