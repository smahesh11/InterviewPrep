using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Sorting_and_Searching
{
	public class SearchInRoatetdArray
	{
		public int Search(int[] arr, int val, int left, int right)
		{

			if (left > right)
				return -1;

			int mid = (left+right) / 2;

			if (arr[mid] == val)
				return mid;
;

			if (arr[left] < arr[mid])
			{
				if (arr[left] <= val && val < arr[mid])
					return Search(arr, val, left, mid - 1);
				else
					return Search(arr, val, mid + 1, right);
			}

			else if (arr[mid] < arr[left])
			{
				if (arr[mid] <= val && val < arr[right])
					return Search(arr, val, mid + 1, right);
				else
					return Search(arr, val, left, mid + 1);
			}

			else if (arr[mid] == arr[left])
			{
				if (arr[mid] != arr[right])
					return Search(arr, val, mid+1, right);
				else
				{
					int result = Search(arr, val, left, mid-1); 

					if (result == -1)
						return Search(arr, val, left, mid - 1);
					else
						return result;

				}
			}
			return -1;
		}
	}
}