using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
	public class IfTwotreesAreIdentical
	{
		public bool AreIdentical(BinaryTreNode root1, BinaryTreNode root2)
		{
			if (root1 == null && root2 == null)
				return true;

			if (root1 == null || root2 == null)
				return false;

			if (root1.GetData == root2.GetData)
			return (AreIdentical(root1.GetLeft, root2.GetLeft) && AreIdentical(root1.GetRight, root2.GetRight));

			return false;
		}
	}
}
