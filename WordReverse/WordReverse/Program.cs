using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* What did I learn?
 * 
 * - In order to use regex I have to add System.Text
 * - I have to creat the Regex object, create a pattern, then use that to create a Match or
 *   MatchList and Use values of the Match as strings.
 * - \s give me any white space
 * - \p{P} gives me any punctuation
 * - \w gives me any letter, number, or _
 * - The answer to the question, why would you change a string to a char array in C# is because
 *		though you can access the elements at a certain index of a string, you can't reassign 
 *		them in string form. It's easier to manipulate the char array and reassign values, 
 *		then create a new string using the char array.
 *		
*/
namespace WordReverse
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input sentence:");
			string sentence = Console.ReadLine();

			WordReverser w = new WordReverser();



			Console.WriteLine(w.ReverseWord(sentence));
			Console.Read();
		}
	}
}
