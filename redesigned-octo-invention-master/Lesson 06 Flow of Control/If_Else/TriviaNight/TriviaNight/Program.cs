using System;

namespace TriviaNight
{
	class Program
	{
		static void Main(string[] args)
		{
			int firstAnswer = 4;
			int secondAnswer = 2;
			int thirdAnswer = 3;
			string enterAnswer;
			int correctAnswer;


			while (true) 
			{
				Console.WriteLine("It's TRIVIA NIGHT! Are you ready?!");
				Console.WriteLine("FIRST QUESTION!");
				Console.WriteLine("What is the Lowest Level Programming Language?");
				Console.Write(" 1) Source Code ");
				Console.WriteLine(" 2) Assembly Language ");
				Console.Write(" 3) C# ");
				Console.WriteLine(" 4) Machine Code ");

				enterAnswer = Console.ReadLine();

				if(int.TryParse(enterAnswer, out correctAnswer))
				{
					if (correctAnswer == firstAnswer)
					{
						Console.WriteLine("YOUR ANSWER: {0}", enterAnswer);
						Console.WriteLine(" ");
						
					}

					Console.WriteLine("SECOND QUESTION!");
					Console.WriteLine("Website Security CAPTCHA Forms Are Descended From the Work of? ");
					Console.Write(" 1) Grace Hopper ");
					Console.WriteLine(" 2) Alan Turing ");
					Console.Write(" 3) Charles Babbage ");
					Console.WriteLine(" 4) Larry Page ");

					if (correctAnswer == secondAnswer)
					{
						Console.WriteLine("YOUR ANSWER: {0}", enterAnswer);
						Console.WriteLine(" ");
						
					}

					enterAnswer = Console.ReadLine();

					Console.WriteLine("LAST QUESTION!");
					Console.WriteLine("Which of These Sci-Fi Ships Was Once Slated for a Full-Size Replica in Las Vegas?");
					Console.Write(" 1) Serenity" );
					Console.WriteLine(" 2) The Battlestar Galactica ");
					Console.Write(" 3) The USS Enterprise " );
					Console.WriteLine(" 4) The Millennium Falcon ");
					if (correctAnswer == thirdAnswer)
					{
						Console.WriteLine("YOUR ANSWER: {0}", enterAnswer);
						Console.WriteLine(" ");
					
					}

					if (correctAnswer == firstAnswer && correctAnswer == secondAnswer && correctAnswer == thirdAnswer)
					{
						Console.WriteLine("Nice job - you got 3 correct!");
					}
					else if (correctAnswer != firstAnswer || correctAnswer != secondAnswer || correctAnswer != thirdAnswer)
					{
						Console.WriteLine("You better study - you did not get any correct!");
					}
				}
			}
		}
	}
}
