using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class TreeNode<T>
    {
        public Object _data;
        public TreeNode<T>[] _neighbours;

        public TreeNode()
        {
        }

        public TreeNode(Object data, TreeNode<T>[] neighbours)
        {
            _data = data;
            _neighbours = neighbours;
        }      
    }

    public class BinaryTreeNode<T> : TreeNode<T>
    {
        TreeNode<T>[] _children = new TreeNode<T>[2];
        public BinaryTreeNode()     
            : base()
        {  }

        public BinaryTreeNode(BinaryTreeNode<T> children)
        {
        }

        public BinaryTreeNode(Object data, BinaryTreeNode<T>[] children)
          : base(data, children)
        {
            _data = base._data;
            _children = children;
        }
        public BinaryTreeNode(Object data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            _data = data;
            _children[0] = left;
            _children[1] = right;
            base._neighbours = _children;
        }

        public BinaryTreeNode<T> GetLeft
        {
              get {
                if (base._neighbours == null)
                    return null;
                return (BinaryTreeNode<T>)base._neighbours[0];
                
            }
            set
            {              
                if (base._neighbours == null)
                    base._neighbours = _neighbours;
            }
        }

        public BinaryTreeNode<T> GetRight
        {  
            get
            {
                if (base._neighbours == null)
                    return null;

                return (BinaryTreeNode<T>)base._neighbours[1];
            }
            
            set
            {
                if (base._neighbours == null)
                {
                    base._neighbours = _children;
                }

            }            
        }
    }

    public class Tree<T>
    {
        public void InOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                InOrderTraversal(root.GetLeft);
                Console.WriteLine(root._data);
                InOrderTraversal(root.GetRight);
            }
            Console.WriteLine();
        }
        public void PreOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root._data);
                PreOrderTraversal(root.GetLeft);
                PreOrderTraversal(root.GetRight);
            }
            Console.WriteLine();
        }
        public void PostOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.GetLeft);
                PostOrderTraversal(root.GetRight);
                Console.WriteLine(root._data);
            }
            Console.WriteLine();
        }      
    } 
    
}

    


   