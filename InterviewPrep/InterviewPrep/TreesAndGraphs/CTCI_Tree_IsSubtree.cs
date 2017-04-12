using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class IsSubtree
    {
        public bool isTreeSubtree(BinaryTreNode small, BinaryTreNode big)
        {
            if (big == null)
                return false;

            if (big.GetData == small.GetData && Matchdata(small, big))
                return true;

            return (isTreeSubtree(small, big.GetLeft) || isTreeSubtree(small, big.GetRight));
        }

        public bool Matchdata(BinaryTreNode T1, BinaryTreNode T2)
        {
            if (T2 == null && T1 == null)
                return true;

            if (T2 == null || T1==null)
                return false;

            if(T1.GetData == T2.GetData)
                return (Matchdata(T1.GetLeft, T2.GetLeft) || Matchdata(T1.GetRight, T2.GetRight));

            //if (T1.GetData != T2.GetData)
            //    return false;

            return false;
        }

    }
}
