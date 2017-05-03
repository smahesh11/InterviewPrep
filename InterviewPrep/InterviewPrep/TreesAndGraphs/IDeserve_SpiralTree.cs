using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
	public class IDeserve_SpiralTree
	{
		public void PrintSpiralTreeWithStacks(BinaryTreNode root)
		{
			//Timecomplexity: O(n)
			//Spacecomplexity: O(n)
			bool evenlevel = true;
			Stack<BinaryTreNode> se = new Stack<BinaryTreNode>();
			Stack<BinaryTreNode> so = new Stack<BinaryTreNode>();

			if (root != null)
				se.Push(root);

			else
				Console.WriteLine("Tree Empty");

			BinaryTreNode x;

			while ((evenlevel && se.Count > 0) || (!evenlevel && so.Count > 0))
			{
				if (evenlevel)
				{
					while (se.Count > 0)
					{
						Console.WriteLine((x = se.Pop()).GetData);
						if (x.GetRight != null) so.Push(x.GetRight);
						if (x.GetLeft != null) so.Push(x.GetLeft);
					}
				}

				else
					while (so.Count > 0)
					{
						Console.WriteLine((x = so.Pop()).GetData);
						if (x.GetLeft != null) se.Push(x.GetLeft);
						if (x.GetRight != null) se.Push(x.GetRight);
					}
				evenlevel = !evenlevel;
			}

		}


		public void Print(BinaryTreNode root, int currentLevel, int height, bool righttoLeft)
		{
			if (root == null)
				return;
			if (currentLevel == height)
			{
				Console.WriteLine(root.GetData);
				return;
			}

			if (righttoLeft)
			{
				Print(root.GetRight, currentLevel + 1, height, righttoLeft);
				Print(root.GetLeft, currentLevel + 1, height, righttoLeft);
			}

			else
			{
				Print(root.GetLeft, currentLevel + 1, height, righttoLeft);
				Print(root.GetRight, currentLevel + 1, height, righttoLeft);
			}
		}
		public void PrintSpiralTreeNoBuffer(BinaryTreNode root)
		{
			//Timecomplexity: O(n^2)
			//Spacecomplexity: O(1)

			bool rightToLeft = true;
			BinaryTree bt = new BinaryTree();
			int height = bt.GetDepth(root);

			for (int i = 0; i < height; i++)
			{
				Print(root, 0, i, rightToLeft);
				rightToLeft = !rightToLeft;
			}
		}
	}
}
