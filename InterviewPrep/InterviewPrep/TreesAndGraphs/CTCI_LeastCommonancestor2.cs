using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class LeastCommonancestor2
    {
        public BinaryTreNode LeastCommonAncestor(BinaryTreNode root, BinaryTreNode p, BinaryTreNode q)
        {
            int diff = Height(root, p) - Height(root, q);
            BinaryTreNode big = diff >= 0 ? p : q;
            BinaryTreNode small = diff < 0 ? p : q;

            while (diff > 0 && big != null)
            {
                big = big.GetParent(root, big);
            }

            while (big != small & big!= null && small!=null)
            {
                big = big.GetParent(root, big);
                small = small.GetParent(root, small);
            }

            if (big != null && small != null)
                return big;

            return null;
        }

        public int Height(BinaryTreNode root, BinaryTreNode n)
        {
            int i = 0;
            BinaryTreNode node = n;
            while (node != root)
            {
                node = node.GetParent(root, node);
                i++;
            }
            return i;
        }
    }
}
