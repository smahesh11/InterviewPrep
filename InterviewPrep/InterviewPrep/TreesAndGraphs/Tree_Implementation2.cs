using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewPrep.Stacks_and_Queues;

namespace InterviewPrep.TreesAndGraphs
{
	public class BinaryTree
	{
		public void InOrderTraversal(BinaryTreNode root)
		{// Time Complexity : O(n)
			if (root != null)
			{
				InOrderTraversal(root.GetLeft);
				Console.WriteLine(root.GetData);
				InOrderTraversal(root.GetRight);
			}
			Console.WriteLine();
		}
		public void PreOrderTraversal(BinaryTreNode root)
		{// Time Complexity : O(n)
			if (root != null)
			{
				Console.WriteLine(root.GetData);
				PreOrderTraversal(root.GetLeft);
				PreOrderTraversal(root.GetRight);
			}
			Console.WriteLine();
		}
		public void PostOrderTraversal(BinaryTreNode root)
		{// Time Complexity : O(n)
			if (root != null)
			{
				PostOrderTraversal(root.GetLeft);
				PostOrderTraversal(root.GetRight);
				Console.WriteLine(root.GetData);
			}
			Console.WriteLine();
		}

		public void IterativePreOrderTraversal(BinaryTreNode root)
		{// Time Complexity : O(n)
			Stack<BinaryTreNode> s = new Stack<BinaryTreNode>();
			if (root != null)
				s.Push(root);
			BinaryTreNode x = new BinaryTreNode(); 
			while (s.Count !=0)
			{
				x = s.Pop();

				Console.WriteLine(x.GetData);
				if(x.GetRight!=null)
					s.Push(x.GetRight);
				if (x.GetLeft != null)
					s.Push(x.GetLeft);
			}			
		}

		public int GetHeight(BinaryTreNode node)
		{// Time Complexity : O(n)
			if (node == null)
				return 0;
			else
				return (1 + Math.Max(GetHeight(node.GetLeft), GetHeight(node.GetRight)));
		}

	}
    public class BinaryTreNode
    {
        int _data;
         BinaryTreNode _left;
         BinaryTreNode _right;
		int _rank;

		public BinaryTreNode()
		{ }

         public BinaryTreNode(int data)
        {
            _data = data;
        }

        public BinaryTreNode GetParent(BinaryTreNode root,BinaryTreNode node)
        {
			if (root == null)
				return null;

			else if (root.GetData == node.GetData)
				return null;

			else if (root.GetLeft != null && root.GetLeft.GetData == node.GetData)
					return root;

				else if (root.GetRight!=null && root.GetRight.GetData == node.GetData)
					return root;

				else if (node.GetData < root.GetData )
					return GetParent(root.GetLeft, node);

				else if (node.GetData > root.GetData )
					return GetParent(root.GetRight, node);			
		           
            return null;
        }

        public int GetData
        {
            get { return _data; }
            set { _data = value; }
        }

        public BinaryTreNode GetLeft
        {
            get { return _left; }
            set { _left = value; }
        }

        public BinaryTreNode GetRight
        {
            get { return _right; }
            set { _right = value; }
        }

		public int GetRank
		{
			get { return _rank; }
			set { _rank = value; }
		}
	}
}
