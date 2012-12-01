using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringReverse
{

	class StringReverse
	{
		public string reverseString(string toReverse)
		{
			char [] reversed = toReverse.ToCharArray();

			for (int i = 0; i < toReverse.Length / 2; i++)
			{
				Swap(i, reversed.Length - i - 1, reversed);
			}

			string temp = new String(reversed);
			return temp;
		}

		private void Swap(int i, int j, char [] s)
		{
			char temp = s[i];
			s[i] = s[j];
			s[j] = temp;
		}
	}
}
