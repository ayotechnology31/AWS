using System;

namespace DifferentKettleOfFish
{
	class Program
	{
		static void Main(string[] args)
		{
            //First type in the following code, make it work!
            //Then take the code, and refactor(or change) the while loop into a for loop!
            //Make the output look the same as it was in the while loop! What changed?!(write in a comment)


            //int fish = 1;

            //while (fish < 10)
            //{
            //    if (fish == 3)
            //    {
            //        Console.WriteLine("RED fish!");
            //    }
            //    else if (fish == 4)
            //    {
            //        Console.WriteLine("BLUE fish!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(fish + " fish!");
            //    }

            //    fish++;
            //}


            int numberLoops = 0;

            for (int i = 1; i < 11; i++)
            {
                if(i==3)
                {
                    Console.WriteLine("RED fish!");
                }
                else if (i == 4)
                {
                    Console.WriteLine("BLUE fish!");
                }
                else
                {
                    Console.WriteLine(i + " fish!");
                }
                numberLoops++;
            }
        }
	}
}
