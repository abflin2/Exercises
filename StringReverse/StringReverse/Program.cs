using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringReverse
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Enter the string to reverse: ");
			string  word = Console.ReadLine();
			DateTime start = DateTime.Now;
			StringReverse reverser = new StringReverse();
			TimeSpan end = DateTime.Now.Subtract(start);

			Console.WriteLine();
			Console.WriteLine("The reversed string is: ");
			Console.WriteLine(reverser.reverseString(word));
			Console.WriteLine();
			Console.WriteLine("It took " + end.Milliseconds + " milliseconds.");

			Console.Read();
		}
	}
}
