using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Sorting_and_Searching
{
	public class SortedSearch_NoSize
	{
		//Time Complexity: O(log n)
		public int Search(int[] array, int item)
		{
			int i = 1;
			while (array[i] != -1 && array[i]<item)
			{
				i*= 2;
			}

			int x = (int)i / 2;
			return BinarySearch(array, item, x, i );
			// return -1; 

		}

		public int BinarySearch(int[] array, int item, int start, int end)		{
			

			while (start <= end)
			{
				int mid = (start + end) / 2;
				if (array[mid] == item)
					return mid;

				if (array[mid] > item && array[mid] != -1)
					end = mid - 1;
				
				else
						if (array[mid] < item)
					start = mid + 1;

			}
			
			 return -1;
		}
	}
}
