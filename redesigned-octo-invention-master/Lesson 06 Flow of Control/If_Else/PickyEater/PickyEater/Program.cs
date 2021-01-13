using System;

namespace PickyEater
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.Write("How many times has it been fried? (#) ");
            int timesFried = Convert.ToInt32(Console.ReadLine());



            Console.Write("Does it have any spinach in it? (y/n) ");
            String hasSpinach = Console.ReadLine();



            Console.Write("Is it covered in cheese? (y/n) ");
            String cheeseCovered = Console.ReadLine();



            Console.Write("How many pats of butter are on top? (#) ");
            int butterPats = Convert.ToInt32(Console.ReadLine());


            Console.Write("Is it covered in chocolate? (y/n) ");
            String chocolatedCovered = Console.ReadLine();



            Console.Write("Does it have a funny name? (y/n) ");
            String funnyName = Console.ReadLine();



            Console.Write("Is it broccoli? (y/n) ");
            String isBroccoli = Console.ReadLine();



            // Conditionals should go here! Here's the first one for FREE!

            //If the food has any spinach in it, or a funny name
            //Print out: "There's no way that'll get eaten."
            if (hasSpinach.Equals("y") || funnyName.Equals("y"))
            {

                Console.WriteLine("There's no way that'll get eaten.");
            }
            //If the food has been fried more than 2 times, but less than 4, and is covered in chocolate
            //Print out: "Oh, it's like a deep fried snickers. That'll be a hit!"
            if (timesFried.Equals(3) && chocolatedCovered.Equals("y"))
            {
                Console.WriteLine("Oh, it's like a deep fried snickers. That'll be a hit!");
            }
            //If it's been fried twice, and is covered in cheese
            //Print out: "Mmm. Yeah, fried cheesy doodles will get et."
            if (timesFried.Equals(2) &&  cheeseCovered.Equals("y"))
            {
                Console.WriteLine("Mmm. Yeah, fried cheesy doodles will get et.");
            }
            //If it is broccoli and has more than 6 pats of butter on top, and is covered in cheese than
            //Print out: "As long as the green is hidden by cheddar, it'll happen!"
            if (isBroccoli.Equals("y") && butterPats.Equals(6) && cheeseCovered.Equals("y"))
            {
                Console.WriteLine("As long as the green is hidden by cheddar, it'll happen!");
            }
            //But otherwise if it is Broccoli
            //Print out: "Oh, green stuff like that might as well go in the bin."
            if (isBroccoli.Equals("y"))
            {
                Console.WriteLine("Oh, green stuff like that might as well go in the bin.");
            }
        }
	}
}
