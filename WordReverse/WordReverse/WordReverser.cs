using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace WordReverse
{
	class WordReverser
	{
		/* This reverser does create a seperate string. I will have to look into doing this with creating a seperate string.
		 * This revers considers white space and punctuation as seperate components and reverses them along with words.
		 * 
		*/
		public string ReverseWord(string sentence)
		{
			//string reversed = "";
			string pattern = @"\w+|\p{P}+|\s+";
			Regex r = new Regex(pattern);
			MatchCollection ms = r.Matches(sentence);
			string[] words = new string[ms.Count];
			int j = 0;
			for (int i = ms.Count-1; i > -1; i--)
			{
				words[j] = ms[i].Value;
				j++;
			}

			return String.Concat(words);
		}
	}
}
