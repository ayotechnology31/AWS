using System;

namespace StringsAreArraysCharacters_Video
{
	class Program
	{
		static void Main(string[] args)
		{

			//////Example 1 -- print out just the vowels
			////// Think about all the possible characters that could appear in a string
			
			//string str = "I like cheese";

			//for (int i = 0; i < str.Length; i++)
			//{
			//	switch (str[i])
			//	{
			//		case 'a':
			//		case 'A':
			//		case 'e':
			//		case 'E':
			//		case 'i':
			//		case 'I':
			//		case 'o':
			//		case 'O':
			//		case 'u':
			//		case 'U':
			//			Console.Write(str[i]);
			//			break;
			//	}
			//}

			////Example 2 -- print out just 'ing;
			/// Think aout the bounds within which your code is valid
			 

			public bool EndsInIng(string str)
			{
				if (str.Length < 3)
					return false;

				if(str[str.Length - 3] == 'i') &&
					str[str.Length - 2] == 'n') &&
					str[str.Length -1] =='g')
			{
				return true;
			}
			return false;
		}
	}
}
