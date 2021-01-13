using System;

namespace FieldDay
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputLastName;
			string teamName;


			Console.WriteLine("What's you last name?");
			inputLastName = Console.ReadLine();
			
			//If a person's name falls before Baggins then they are on the team "Red Dragons"
			if(inputLastName.StartsWith("Bag"))
			{
				Console.WriteLine("Aha! You’re on the team “Black Holes”!");

			}

			//If it falls after Baggins, but before Dresden, they are on the team "Dark Wizards"
			//If it falls after Dresden, but before Howl, they are on the team "Moving Castles"
			//If it falls after Howl, but before Potter, they are on the team "Golden Snitches"
			//If it falls after Potter, but before Vimes, they are on the team "Night Guards"
			//If it falls after Vimes, they are on the team “Black Holes”
		}
	}
}
