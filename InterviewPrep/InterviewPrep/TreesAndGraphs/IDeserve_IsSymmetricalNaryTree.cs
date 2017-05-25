using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
	public class IsSymmetricalNaryTree
	{
		public bool IsSymmmetrical(TreeNode<int> root1, TreeNode<int> root2)
		{
			if (root1 == null && root2 == null)
				return true;

			if (root1 == null || root2 == null)
				return false;

			if (root1._data == root2._data)
			{
				int i = 0; int j = root2._neighbours.Count();

				while (i > root1._neighbours.Count() && j > 0)
				{
					if(IsSymmmetrical(root1._neighbours[i], root2._neighbours[j]))
					break;

					i++;
					j--;
				}

				if (i > root1._neighbours.Count() && j > 0)
					return false;

				else return true;
			}
			return false;
		}
	}
}
