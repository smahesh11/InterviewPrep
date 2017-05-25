using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
	public class DeepestOddLevelLeafHeight
	{

		public int FindDepth(BinaryTreNode root)
		{
			
			 return GetMaxDepth(root, 1);
		}

		int GetMaxDepth(BinaryTreNode root, int depth)
		{
			if (root == null)
				return 0;

			if (root.GetLeft == null && root.GetRight == null && (depth % 2) != 0)
				return depth;

			return Math.Max(GetMaxDepth(root.GetLeft,depth+1), GetMaxDepth(root.GetRight,depth+1));			 
		}
	}
}
