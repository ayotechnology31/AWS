using System;

namespace BiggerBetterAdder
{
	class Program
	{
		static void Main(string[] args)
		{
			//Take your code and fix the "Best Adder Ever" from the previous section, but instead of using hardcoded values store in the variables, ask the user for input for the numbers that they’re going to add together and THEN display the results.
			int num1, num2, num3;
			Console.Write("Enter a number: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a number: ");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a number: ");
			num3 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(num1 + num2 + num3);
		}
	}
}
