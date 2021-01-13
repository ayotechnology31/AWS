using System;

namespace MethodToTheMadness
{
	class Program
	{

        //Type out the following code! Make it work!
        //Add in the second method call needed to print out the rest of quote!

        static void Main(string[] args)
		{
            EatMe();

            Console.WriteLine("\n ? Lewis Carroll, Alice in Wonderland");
        }

        static void EatMe()
        {
            //Console.WriteLine("'But I don’t want to go among mad people,' Alice remarked.");
            //Console.WriteLine("'Oh, you can’t help that,' said the Cat.");
            //Console.Write("'Oh, you can’t help that,' said the Cat.");
            //Console.Write("'Oh, you can’t help that,' said the Cat.");
            Console.WriteLine("'But I don’t want to go among mad people,' Alice remarked.");
            Console.WriteLine("'Oh, you can’t help that,' said the Cat.");
            Console.WriteLine("'We’re all mad here. I’m mad. You’re mad.' 'How do you know I’m mad?' said Alice.'");
            Console.WriteLine("'You must be,' said the Cat, 'or you wouldn’t have come here.'");
        }

        static void DrinkMe()
        {
            Console.WriteLine("'How do you know I’m mad?' said Alice.");
            Console.WriteLine("'You must be,' said the Cat, 'or you wouldn’t have come here.'");
        }
    }
}
