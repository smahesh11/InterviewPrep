using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
	//Time Complexity: O(n)
	public class IssSymmetricalBinaryTree
	{
		public bool IsSymmetrical(BinaryTreNode root1, BinaryTreNode root2)
		{
			if (root1 == null && root2 == null)
				return true;

			if (root1 == null||root2==null)
			return false;

			if (root1.GetData == root2.GetData)
			{
				if (IsSymmetrical(root1.GetLeft, root2.GetRight))
					return IsSymmetrical(root1.GetRight, root2.GetLeft);
			}

			return false;
		}
	}
}
