using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class BinaryTree
    {
        public void InOrderTraversal(BinaryTreNode root)
        {
            if (root != null)
            {
                InOrderTraversal(root.GetLeft);
                Console.WriteLine(root.GetData);
                InOrderTraversal(root.GetRight);
            }
            Console.WriteLine();
        }
        public void PreOrderTraversal(BinaryTreNode root)
        {
            if (root != null)
            {
                Console.WriteLine(root.GetData);
                PreOrderTraversal(root.GetLeft);
                PreOrderTraversal(root.GetRight);
            }
            Console.WriteLine();
        }
        public void PostOrderTraversal(BinaryTreNode root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.GetLeft);
                PostOrderTraversal(root.GetRight);
                Console.WriteLine(root.GetData);
            }
            Console.WriteLine();
        }
    }
    public class BinaryTreNode
    {
        int _data;
        public BinaryTreNode left;
        public BinaryTreNode right;

         public BinaryTreNode(int data)
        {
            _data = data;
        }

        public BinaryTreNode GetParent(BinaryTreNode root,BinaryTreNode node)
        {            
            while (root != null)
            {
                if ((root.GetLeft != null && root.GetLeft == node || root.GetRight != null && root.GetRight == node))
                    return root;


                if (GetParent(root.left, node) != null)
                    return GetParent(root.left, node);

                else if (GetParent(root.right, node) != null)
                    return GetParent(root.right, node);         
            }
            return null;
        }

        public int GetData
        {
            get { return _data; }
        }

        public BinaryTreNode GetLeft
        {
            get { return left; } 
        }

        public BinaryTreNode GetRight
        {
            get { return right; }
        }
    }
}
