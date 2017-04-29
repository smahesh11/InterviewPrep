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
        public BinaryTreNode _left;
        public BinaryTreNode _right;

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


                if (GetParent(root.GetLeft, node) != null)
                    return GetParent(root.GetLeft, node);

                else if (GetParent(root.GetRight, node) != null)
                    return GetParent(root.GetRight, node);         
            }
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
    }
}
