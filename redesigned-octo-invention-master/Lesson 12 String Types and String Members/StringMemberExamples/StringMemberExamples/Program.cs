using System;

namespace StringMemberExamples
{
	class Program
	{
		static void Main(string[] args)
		{
            /////Here are some examples of using the string members to manipulate strings. We recommend you copy these examples into a console application and play around with them. Change things, get to know your string members!
            ////Finding the indexes of all the letter e's in a string:
            string s = "I like cheese";

            int i = 0; // start index

            // loop until we explicitly break
            while (true)
            {
                // check for an e starting at index i
                i = s.IndexOf("e", i);

                if (i == -1)
                    break; // no more e's
                else
                    Console.WriteLine($"Found an e at index: {i}");

                // move to the next index after the e we found.
                i++;
            }


            /////Splitting a sentence into individual words
            //string s = "I like cheese";

            //string[] words = s.Split(' ');

            //// loop through all the elements
            //for (int i = 0; i < words.Length; i++)
            //{
            //    // print the word at element index i
            //    Console.WriteLine(words[i]);
            //}


            /////Splitting the same sentence on all common punctuation and spaces but removing empty entries
            ////////The StringSplitOptions.RemoveEmptyEntries is needed since there is a period and a space next to each other which would result in an empty "" element in the words array.
            //string s = "I like cheese. Lots!";

            //char[] delimiters = { ',', '!', '.', ' ' };
            //// split on all the delimiters and remove any empty ones
            //string[] words = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            //// loop through all the elements
            //for (int i = 0; i < words.Length; i++)
            //{
            //    // print the word at element index i
            //    Console.WriteLine(words[i]);
            //}


            /////Joining a list of values into a comma delimited string
            //int[] numbers = { 5, 10, 15, 20 };
            //Console.WriteLine(string.Join(",", numbers));
            //Console.WriteLine(string.Join(" | ", numbers));


            ////Determining whether a string has two vowels next to each other
            //public bool HasConsecutiveVowels(string s)
            //{
            //    // index 0 to the next-to-last index since we are selecting 2 characters at a time.
            //    for (int i = 0; i < s.Length - 1; i++)
            //    {
            //        // get the current char
            //        char current = s[i];
            //        // get the char to the right of current
            //        char next = s[i + 1];

            //        if (IsVowel(current) && IsVowel(next))
            //        {
            //            // we found two vowels, we can stop now
            //            return true;
            //        }
            //    }

            //    // we looped the whole string and didn't find two vowels
            //    return false;
            //}

            //public bool IsVowel(char c)
            //{
            //    switch (c)
            //    {
            //        case 'a':
            //        case 'A':
            //        case 'e':
            //        case 'E':
            //        case 'i':
            //        case 'I':
            //        case 'o':
            //        case 'O':
            //        case 'u':
            //        case 'U':
            //            return true;
            //        default:
            //            return false;
            //    }
            //}
            //Pay close attention to a few things in the above code snippet:
            //We loop to s.Length - 1.This is because we are reading the current character and the next character.Because the last character in the string does not have a next character, we have to stop the loop early or we will get an Index Out of Range exception.
            //We return true before finishing the loop if we find any instance of two vowels next to each other, we can stop.
            //We can just use the expression[i + 1] to get to the next character in the string.An index is an expression, so it can be a variable, a literal, a calculation, or a method return value.



            ////Printing a List of Characters and Values
            ////As we mentioned in the Unicode section above each character can be represented numerically. Here is a code snippet that prints out the characters associated with the first 256 numbers:

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //for (int i = 0; i < 255; i++)
            //{
            //    char symbol = (char)i;
            //    Console.WriteLine("{0} -> {1}", i, symbol);
            //}


            int[] numbers = new int[] { 3, 1, 4 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"The number at index {i} is {numbers[i]}.");
            }

        }
	}
}
