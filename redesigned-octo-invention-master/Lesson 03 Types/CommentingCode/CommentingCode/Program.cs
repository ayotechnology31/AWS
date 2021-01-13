using System;

namespace CommentingCode
{
	class Program
	{
		static void Main(string[] args)
		{
            // Comments are written to explain code in an easily   // understandable way
            // Basically for single lines   // anything after // is considered a comment
            Console.WriteLine("Normal code is compiled and runs ...");
            Console.WriteLine("Comments however ... ");// do not execute!

            // Comments can be on their own line
            Console.WriteLine("..."); // or they can share like this

            // However if you put the // BEFORE a line of code
            // Console.WriteLine("Then it is considered a comment");
            // Console.WriteLine("and won't execute!");
            /*

               This is a multi-lined comment!
               Named because, well, it spans SO many lines!

            */
        }
    }
}
