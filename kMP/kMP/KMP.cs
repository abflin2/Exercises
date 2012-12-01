using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace kMP
{
	class KMP
	{
		//pattern
		//data
		//path to find data

		public string intext
		{
			get
			{
				if (intext != null)
					return intext;
				else
				{

				}
			}

			set 
			{
				
			}

		}
		string toFind; //pattern
		//string inText; //text used to look for pattern

		public KMP(string P, string T) 
		{
			toFind = P;
			inText = T;

			

		}

		public KMP(string P, StreamReader S)
		{
			string text = S.ReadToEnd();

			KMP(P, text);
		}
	}
}
