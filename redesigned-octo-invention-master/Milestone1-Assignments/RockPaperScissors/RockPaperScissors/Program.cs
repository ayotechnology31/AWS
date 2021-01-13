using System;

namespace RockPaperScissors
{
	class Program
	{
		static void Main(string[] args)
		{
			//Rules
			//The rules of the game are as follows:

			//Each player chooses Rock, Paper, or Scissors.
			//If both players choose the same thing, the round is a tie.
			//Otherwise:
			//Paper wraps Rock to win
			//Scissors cut Paper to win
			//Rock breaks Scissors to win


			//Requirements
			//This program will be a Console Application called RockPaperScissors.
			//The program first asks the user how many rounds he/ she wants to play.
			//Maximum number of rounds = 10, minimum number of rounds = 1.If the user asks for something outside this range, the program prints an error message and quits.
			//If the number of rounds is in range, the program plays that number of rounds.Each round is played according to the requirements below.
			//For each round of Rock, Paper, Scissors, the program does the following:
			//The computer asks the user for his / her choice(Rock, Paper, or Scissors).
			//Hint: 1 = Rock, 2 = Paper, 3 = Scissors
			//After the computer asks for the user’s input, the computer randomly chooses Rock, Paper, or Scissors and displays the result of the round(tie, user win, or computer win).
			//Hint: use the Random class.
			//The program must keep track of how many rounds are ties, user wins, or computer wins.
			//Hint: Create three variables to keep track of these items and update them correctly after each round.
			//The program must print out the number of ties, user wins, and computer wins and declare the overall winner based on who won more rounds.
			//After all rounds have been played and the winner declared, the program must ask the user if he/she wants to play again.
			//If the user says No, the program prints out a message saying, “Thanks for playing!” and then exits.
			//If the user says Yes, the program starts over, asking the user how many rounds he/she would like to play.

			int rounds;
			int rock = 1;
			int paper = 2;
			int scissors = 3;
			int userChoice;
			int numberLoops = 0;
			int numberTie = 0;
			int numberUserWins = 0;
			int numberComputerWins = 0;
			string keepPlaying = "y";


			while (keepPlaying.Equals("y"))
			{
				Console.WriteLine("Let's play Paper, Rock, Scissors! How many rounds do you want to play?");
				string input = Console.ReadLine();

				if (int.TryParse(input, out rounds))
				{
					for (int i = 0; i < rounds; i++)
					{
						if ((rounds < 1) || (rounds > 10))
						{
							Console.WriteLine("You must choose a number between 1 and 10.");
							return;
						}

						Console.WriteLine("Choose 1 for Rock, 2 for Paper, or 3 for Scissors.");
						input = Console.ReadLine();

						//computer picks
						Random chooseObject = new Random();
						int computerChoice = chooseObject.Next(1, 3);

						if (int.TryParse(input, out userChoice))
						{
							numberLoops++;
							///TIE
							if (userChoice == rock && computerChoice == rock)
							{
								numberTie++;
								Console.WriteLine($"You picked {rock}. Your opponent picked {rock}. It's a tie!");
							}
							if (userChoice == paper && computerChoice == paper)
							{
								numberTie++;
								Console.WriteLine($"You picked {paper}. Your opponent picked {paper}. It's a tie!");
							}
							if (userChoice == scissors && computerChoice == scissors)
							{
								numberTie++;
								Console.WriteLine($"You picked {scissors}. Your opponent picked {scissors}. It's a tie!");
							}

							//Paper wraps Rock to win
							if ((computerChoice == paper && userChoice == rock) || (computerChoice == rock && userChoice == paper))
							{
								if (userChoice > computerChoice)
								{
									numberUserWins++;
									Console.WriteLine($"You picked {paper}. Your opponent picked {rock}. You win!");
								}
								else
								{
									numberComputerWins++;
									Console.WriteLine($"You picked {rock}. Your opponent picked {paper}. Computer wins!");
								}
							}
							//Scissors cut Paper to win
							if ((computerChoice == paper && userChoice == scissors) || (computerChoice == scissors && userChoice == paper))
							{
								if (userChoice > computerChoice)
								{
									numberUserWins++;
									Console.WriteLine($"You picked {scissors}. Your opponent picked {paper}. You win!");
								}
								else
								{
									numberComputerWins++;
									Console.WriteLine($"You picked {paper}. Your opponent picked {scissors}. Computer wins!");
								}

							}
							//Rock breaks Scissors to win
							if ((computerChoice == scissors && userChoice == rock) || (computerChoice == rock && userChoice == scissors))
							{
								if(userChoice < computerChoice)
								{
									numberUserWins++;
									Console.WriteLine($"You picked {rock}. Your opponent picked {scissors}. You win!");
								}
								else
								{
									numberComputerWins++;
									Console.WriteLine($"You picked {scissors}. Your opponent picked {rock}. Computer wins!");
								}
							}

							if (numberLoops == rounds)
							{
								break;
							}
							continue;
						}
					}
					Console.WriteLine("There are " + numberTie + " ties, " + numberUserWins + " user wins, and " + numberComputerWins + " computer wins.");
					if (numberComputerWins > numberUserWins)
					{
						Console.WriteLine("Computer Wins!");
					}
					else if (numberUserWins > numberComputerWins)
					{
						Console.WriteLine("You Win!");
					}
					else
					{
						Console.WriteLine("It's a tie!");
					}

					Console.WriteLine("Do you want to play again? (y/n) ");
					keepPlaying = Console.ReadLine();
					if (keepPlaying.Equals("n"))
					{
						Console.WriteLine("Thanks for playing!");
						return;
					}
				}
			}
		}
	}
}


//numberLoops++;
//if (computerChoice > rock || computerChoice > paper || computerChoice > scissors)
//{
//	numberComputerWins++;
//	if (numberLoops == rounds)
//	{
//		break;
//	}
//	continue;
//}
//else if (paper > computerChoice || scissors > computerChoice || rock > computerChoice)
//{
//	numberUserWins++;
//	if (numberLoops == rounds)
//	{
//		break;
//	}
//	continue;
//}
//else if (paper == computerChoice || scissors == computerChoice || rock == computerChoice)
//{
//	numberTie++;
//	if (numberLoops == rounds)
//	{
//		break;
//	}
//	continue;
//}


//Console.WriteLine("Do you want to play again? (y/n) ");
//string playAgain = Console.ReadLine();
//if (playAgain.Equals("y"))
//{
//	continue;
//}
//else if (playAgain.Equals("n"))
//{
//	Console.WriteLine("Thanks for playing!");
//	return;
//}
