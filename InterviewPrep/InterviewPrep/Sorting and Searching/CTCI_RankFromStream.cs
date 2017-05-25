using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewPrep.TreesAndGraphs;

namespace InterviewPrep.Sorting_and_Searching
{

	class RankTree : BinaryTreNode
	{
		BinaryTreNode bt = new BinaryTreNode();
		BinaryTreNode _root;
		BinaryTreNode _node;
		
		public int Rank(int[] arr, int x)
		{

			foreach (int item in arr)
			{
				if (_root == null)
				{
					_root = new BinaryTreNode(item);
					_node = _root;
				}

				else Insert(_root, item);
			}

			return FindRank(_node, x);
		}

		public int FindRank(BinaryTreNode root, int x)
		{
			if (root.GetData == x)
				return root.GetRank;

			if (x < root.GetData)
				if (root.GetLeft == null)
					return -1;
				else
					return FindRank(root.GetLeft, x);

			else if (root.GetRight == null)
				return -1;
			else
				return root.GetRank + 1 + FindRank(root.GetRight, x);
		}

		void Insert(BinaryTreNode root, int x)
		{
			//if (root == null)
			//{
			//	root = new BinaryTreNode(x);
			//	_node = root;
			//}

			if (x < root.GetData)
			{
				if (root.GetLeft == null)
					root.GetLeft = new BinaryTreNode(x);
				else
				{
					Insert(root.GetLeft, x);
					root.GetRank++;
				}
			}

			else
				if (root.GetRight == null)
				root.GetRight = new BinaryTreNode(x);
			else
				Insert(root.GetRight, x);

		}
	}
}
