using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Sorting_and_Searching
{
	public class SparceSearch
	{
		public int GetSearchIndexIterative(string[] arr, string item)
		{
			for(int i =0;i<arr.Length;i++)
			{
				if (!string.IsNullOrEmpty(arr[i]))
					if (arr[i].Equals(item))
						return i;
			}
			
			return -1;		
		}

		public int GetSearchRecursive(string[] arr, string item, int start, int end)
		{

			if (string.IsNullOrEmpty(item))
				return -1;

			int mid = (start + end) / 2;

			if (arr[mid] == item)
				return mid;

			if (end < start)
				return -1;

			if (string.IsNullOrEmpty(arr[mid]))
			{
				int left = mid - 1;
				int right = mid + 1;

				while (true)
				{
					if (left < start && right > end)
						return -1;

					if (left >= start && !string.IsNullOrEmpty(arr[left]))
					{
						mid = left;
						break;
					}

					else if (right <= end && !string.IsNullOrEmpty(arr[right]))
					{
						mid = right;
						break;
					}

					left--;
					right++;
				}
			}

				if (item.Equals(arr[mid]))
					return mid;

				else if (item.CompareTo(arr[mid]) < 0)
					return GetSearchRecursive(arr, item, start, mid - 1);
				else
				return GetSearchRecursive(arr,item, mid+1, end);
					
		}
	}
}
