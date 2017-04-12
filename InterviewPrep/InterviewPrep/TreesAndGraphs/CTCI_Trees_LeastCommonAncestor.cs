using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class CTLeastCommonAncestor
    {
        public BinaryTreNode LeastCommonAncestor(BinaryTreNode root, BinaryTreNode  p, BinaryTreNode q)
        {
            BinaryTreNode current = root;

            if (current == null)
                return null;
            if (current == p || current == q)
                return current;

            BinaryTreNode left = LeastCommonAncestor(current.GetLeft, p, q);
            BinaryTreNode right = LeastCommonAncestor(current.GetRight, p, q);

            if (left != null && right != null)
                return current;

            if (left == null)
                return right;

            return left;
        }
    }
}
