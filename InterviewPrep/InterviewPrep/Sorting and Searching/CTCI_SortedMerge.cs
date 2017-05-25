using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Sorting_and_Searching
{
	public class SortedMerge
	{
		public int[] Merge(int[] one, int[] two, int oneLast, int twoLast)
		{
			//TimeComplexity :O(n)
			//Spacecomplexity :O(1)
			int oneSize = one.Length;
			int twoSize = two.Length;


			if (oneSize < oneLast + twoLast)
				return new int[0];

			while (twoLast >= 0)
			{
				if (one[oneLast] < two[twoLast])
				{
					one[oneSize] = two[twoLast];
					twoSize--;
				}

				else
				{
					one[oneSize] = two[twoLast];
					twoLast--;
				}

				oneSize--;
			}

			return one;
		}
	
	}
}
