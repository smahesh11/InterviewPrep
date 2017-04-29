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
            if (node.GetRight != null)
            {
                BinaryTreNode x = node.GetRight;

                while (x != null)
                    x = x.GetLeft;

                return x;
            }

            //BinaryTreNode succ = null;
            //while (root != null)
            //{
            //    if (node.GetData < root.GetData)
            //    {
            //        succ = root;
            //        if (root.GetLeft != null)
            //            root = root.GetLeft;
            //    }

            //    if (node.GetData > root.GetData)
            //    {
            //        if (root.GetRight != null)
            //            root = root.GetRight;
            //    }
            //}

            //return succ;              
            else {
                BinaryTreNode x = node;
                BinaryTreNode p = x.GetParent(root, node);
                while (p!= null && p.GetLeft!=x)
                {
                    x = p;
                    p = p.GetParent(root, x);
                }
                return x;
            }
        }
    }
}
