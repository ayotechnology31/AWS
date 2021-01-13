using System;

namespace MiniZork
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("You are standing in an open field west of a white house,");
            Console.WriteLine("With a boarded front door.");
            Console.WriteLine("There is a small mailbox here.");
            Console.Write("Go to the house, or open the mailbox? ");

            String action = Console.ReadLine();

            if (action.Equals("open the mailbox"))
            {
                Console.WriteLine("You open the mailbox.");
                Console.WriteLine("It's really dark in there.");
                Console.Write("Look inside or stick your hand in? ");
                action = Console.ReadLine();

                if (action.Equals("look inside"))
                {
                    Console.WriteLine("You peer inside the mailbox.");
                    Console.WriteLine("It's really very dark. So ... so very dark.");
                    Console.Write("Run away or keep looking? ");
                    action = Console.ReadLine();

                    if (action.Equals("keep looking"))
                    {
                        Console.WriteLine("Turns out, hanging out around dark places isn't a good idea.");
                        Console.WriteLine("You've been eaten by a grue.");
                    }
                    else if (action.Equals("run away"))
                    {
                        Console.WriteLine("You run away screaming across the fields - looking very foolish.");
                        Console.WriteLine("But you alive. Possibly a wise choice.");
                    }
                }
                else if (action.Equals("stick your hand in")) 
                {
                    Console.WriteLine("You feel an old, dusty paper");
                    Console.WriteLine("It's got a crest on it");
                    Console.Write("Read it or put it back ");
                    action = Console.ReadLine();

                    if (action.Equals("Read it"))
                    {
                        Console.WriteLine("It's a treasure map");
                        Console.WriteLine("Adventure continues");
                    }
                    else if (action.Equals("put it back"))
                    {
                        Console.WriteLine("You feel something crawling on you.");
                        Console.WriteLine("You've been biten by a spider!");
                    }
                }
            }
            else if (action.Equals("go to the house")) 
            {
                Console.WriteLine("The door creeks open and the house looks royal");
                Console.WriteLine("You walk into the library and there's box");
                Console.Write("Open it or take it ");
                action = Console.ReadLine();

                if (action.Equals("Open it"))
                {
                    Console.WriteLine("It needs a key");
                    Console.WriteLine("You are not the chosen one");
                }
                else if (action.Equals("Take it "))
                {
                    Console.WriteLine("Archeologist study it");
                    Console.WriteLine("You are a hero!");
                }
            }
        }
	}
}
