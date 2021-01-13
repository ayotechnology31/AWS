using System;

namespace StringCalculatorKata
{
	public class Calculator
	{
		/// <summary>
		/// Video: String Calculator Kata - Part 1
		/// </summary>

		//public int Add(string numbers)
		//{
		//	if (numbers == "")
		//		return 0;

		//	return int.Parse(numbers);
		//}

		/// <summary>
		/// Video: String Calculator Kata - Part 2
		/// </summary>
		//public int Add(string numbers)
		//{
		//	///before refactor
		//	//if (numbers == "")
		//	//	return 0;

		//	//if(numbers.Contains(","))
		//	//{
		//	//	// split and sum
		//	//	var elements = numbers.Split(',');
		//	//	return int.Parse(elements[0]) + int.Parse(elements[1]);
		//	//}
		//	//else
		//	//{
		//	//	return int.Parse(numbers);
		//	//}

		//	///refactor
		//	int sum = 0;
		//	if (numbers == "")
		//		return sum;
		//	if (numbers == "")
		//		return 0;

		//	if (numbers.Contains(","))
		//	{
		//		// split and sum
		//		var elements = numbers.Split(',');
		//		sum += int.Parse(elements[0]);
		//		sum += int.Parse(elements[1]);

		//	}
		//	else
		//	{
		//		sum += int.Parse(numbers);
		//	}

		//	return sum;
		//}


		/// <summary>
		/// Video: String Calculator Kata - Part 3
		/// </summary>
		/// 
		public int Add(string numbers)
		{
			int sum = 0;

			if (numbers == "")
				return sum;

			if (numbers.Contains(","))
			{
				//split and sum
				string[] elements = numbers.Split(',');

				for (int i = 0; i < elements.Length; i++)
				{
					sum += int.Parse(elements[i]);
				}
			}
			else
			{
				sum += int.Parse(numbers);
			}

			return sum;
		}
	}
}
