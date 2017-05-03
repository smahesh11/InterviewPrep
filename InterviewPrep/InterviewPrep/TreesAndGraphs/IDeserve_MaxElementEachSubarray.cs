using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
	public class IDeserve_MaxElementEachSubarray
	{
		public List<int> MaxelementsList(List<int> array, int k)
		{
			List<int> maxElements = new List<int>();

			int[] temp = new int[k];
			for (int i = 0; i < k; i++)
			{
				temp[i] = array[i];
			}
			maxElements.Add(GetMax(temp).GetData);
			for (int i = 0; i < array.Count-k-1; i++)
			{
				temp[i] = array[i + k];
				maxElements.Add(GetMax(temp).GetData);
			}

			return maxElements;
		}

		public BinaryTreNode GetMax(int[] arr)
		{
			BinaryTreNode node = new BinaryTreNode();
			//CreateBSt from unsorted array 
			return node;
		}
	}

}
