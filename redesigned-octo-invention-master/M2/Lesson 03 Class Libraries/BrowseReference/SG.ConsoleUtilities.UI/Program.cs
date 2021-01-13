using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCG.ConsoleUtilities;

namespace SG.ConsoleUtilities.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput ui = new UserInput();

            int age = ui.GetIntFromUser("Enter your age: ");
            int num = ui.GetIntFromUser("Enter your favorite number: ");

            Console.WriteLine($"Your age is {age} and your favorite number is {num}");
            Console.ReadLine();
        }
    }
}
