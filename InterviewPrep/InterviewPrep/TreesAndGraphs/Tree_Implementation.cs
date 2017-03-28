using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class TreeNode<T>
    {
        public Object data;
        public TreeNode<T>[] neighbours;
        public Object[] Nodes;

        public TreeNode()
        {
        }

        public TreeNode(Object data)
        {
            this.data = data;
        }
        public TreeNode(Object data, TreeNode<T>[] neighbours)
        {
            this.data = data;
            this.neighbours = neighbours;
        }
    }

    public class BinaryTreeNode<T> : TreeNode<T>
    {
        TreeNode<T>[] children = new TreeNode<T>[2];
        public BinaryTreeNode()     
            : base()
        {  }

        public BinaryTreeNode(Object data)
          : base(data)
        {
            this.data = base.data;
        }
        public BinaryTreeNode(Object data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.data = data;
            children[0] = left;
            children[1] = right;
            base.neighbours = children;
        }

        public BinaryTreeNode<T> GetLeft
        {
              get {
                if (base.neighbours == null)
                    return null;
                return (BinaryTreeNode<T>)base.neighbours[0];
                
            }
            set
            {
                //AddData<T> add = new AddData<T>();
                if (base.neighbours == null)
                    base.neighbours = neighbours;
            }
        }

        public BinaryTreeNode<T> GetRight
        {  
            get
            {
                if (base.neighbours == null)
                    return null;

                return (BinaryTreeNode<T>)base.neighbours[1];
            }
            
            set
            {
                if (base.neighbours == null)
                {
                    base.neighbours = children;
                }

            }            
        }
    }

    public partial class Tree<T>
    {
        public void InOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                InOrderTraversal(root.GetLeft);
                Console.WriteLine(root.data);
                InOrderTraversal(root.GetRight);
            }
        }
        public void PreOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                InOrderTraversal(root.GetLeft);
                InOrderTraversal(root.GetRight);
            }
        }
        public void PostOrderTraversal(BinaryTreeNode<T> root)
        {
            if (root != null)
            {
                InOrderTraversal(root.GetLeft);
                InOrderTraversal(root.GetRight);
                Console.WriteLine(root.data);
            }
        }
    }

        //public class AddData<T>
        //{
        //    List<Object> nodes = new List<object>();
        //    public List<Object> Add(List<Object> nodes)
        //    {
        //        this.nodes = nodes;
        //    return nodes;
        //    }         
        //}
    
}

    


   