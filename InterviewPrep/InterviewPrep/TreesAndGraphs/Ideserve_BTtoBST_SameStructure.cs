using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
	public class BTtoBSTSameStructure
	{
		public BinaryTreNode ToBST(BinaryTreNode root)
		{
			int[] index= new int[1];
			List<int> inorder = new List<int>();
			ConvertToInorder(root, inorder,  index);

			inorder.Sort();
			index[0] = 0;
			
			ReplaceNodes(root, inorder, index);

			return root;
		}

		public  void ConvertToInorder(BinaryTreNode root, List<int> inorder, int[] index)
		{
			if (root == null)
				return;

			ConvertToInorder(root.GetLeft, inorder, index);
			inorder.Add(root.GetData); 
			index[0]++;
			ConvertToInorder(root.GetRight, inorder, index);
		}

		public void ReplaceNodes(BinaryTreNode root, List<int> inorder, int[] i)
		{
			if (root == null)
				return;
			ReplaceNodes(root.GetLeft, inorder, i);

			root.GetData = inorder[i[0]];
			i[0]++;

			ReplaceNodes(root.GetRight, inorder, i);
		}		
	}


}
