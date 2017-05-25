using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    class InOrderSuccessor
    {
		public BinaryTreNode GetSuccessor(BinaryTreNode root, BinaryTreNode node)
		{
			BinaryTreNode x = new BinaryTreNode();
			x = node;

			if (x.GetRight == null)
				return x.GetParent(root,x);

			if (x.GetRight != null  && x==x.GetParent(root,x).GetLeft)
				return GetLeftMostChild(x.GetRight);

			BinaryTreNode p = new BinaryTreNode();

			while (p != null && p.GetLeft != x)
			{
				x = p;
				p = x.GetParent(root,x);				
			}

			if (p != null)
				return p;

			return null;

		}

		BinaryTreNode GetLeftMostChild(BinaryTreNode node)
		{
			BinaryTreNode x = new BinaryTreNode();

			while (x.GetLeft != null)
			{
				x = x.GetLeft;
			}

			return x;
		}
        
        
    }
}
