using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
	public class IsSubTree2
	{
		public bool IsSubtree(BinaryTreNode big, BinaryTreNode small)
		{
			if (big == null)
				return false;

			if (small == null)
				return true;

			string[] str1 = new string[] { "" };
			string[] str2 = new string[] { "" };
			string[] str3 = new string[] { "" };
			string[] str4 = new string[] { "" };
		
			PreOrder(big, str1);
			PreOrder(small, str2);

			InOrder(big, str3);
			InOrder(small, str4);

			if (str1[0].Contains(str2[0]) && str3[0].Contains(str4[0]))
			{				
				return true;
			}
			
		return false;
		}

		void PreOrder(BinaryTreNode root, string[] pre)
		{		
			
			if (root != null)
			{
				pre[0] += root.GetData.ToString() ;
				PreOrder(root.GetLeft,pre);
				PreOrder(root.GetRight,pre);
			}
						
		}

		void InOrder(BinaryTreNode root,string[] inorder)
		{						
			if (root != null)
			{
				InOrder(root.GetLeft,inorder);
				inorder[0] +=  root.GetData.ToString() ;
				InOrder(root.GetRight,inorder);
			}

			
		}

	}
}
