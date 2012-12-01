using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * I got this question in a phone interview. Take an array of unknown size with
 * repeat ints and get an array of unique ints. I'd like to try to solve it. I 
 * was told that the most efficient way would be to use hashing. I need to 
 * understand hashing algorithms and learn how to implement them. I think that
 * implementation with research is the best way.
 * 
 * Prerequisites:
 * -Numbers are limited to the properties of ints. 
 * 
 * 
 */

namespace FindUniqueNumberSet
{

	class Program
	{
		Random rand = new Random();
		
		static void Main(string[] args)
		{
			int[] messyArray = getRandomArray();
			HashSet<int> intSet = new HashSet<int>();

			for (int i = 0; i < messyArray.Length; i++)
			{
	//			if(!intSet.Contains(messyArray[i]))
	//			{
					intSet.Add(messyArray[i]);
	//			}
			}

		}

		public static int[] getRandomArray()
		{
			/*Creation of the random array wasn't really part of the assignment
			*	but I have to have one to evaluate it. This one needs work. 
			*	Random in c# isn't very random. Also, I had to set a false ceiling on the size
			*	because Random almost always creates a huge number when you set the ceiling
			*	at max. 
			*/

			int[] randomArray = new int[new Random().Next(1000000)];
			Random rand = new Random();
			for (int i = 0; i < randomArray.Length; i++)
			{
				randomArray[i] = rand.Next(int.MaxValue);
				int neg = rand.Next(int.MaxValue) % 2;

				if (neg > 0)
				{
					randomArray[i] *= -1;
				}
			}

			return randomArray;
		}
	}
}
