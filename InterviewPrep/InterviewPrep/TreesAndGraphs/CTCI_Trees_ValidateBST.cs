using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class ValidateBST
    {
        public bool CheckIsBST(BinaryTreNode root)
        {
            return IsBST(root, null, null);
        }
        public bool IsBST(BinaryTreNode root, BinaryTreNode min, BinaryTreNode max)
        {
            if (root == null)
                return true;

            if ((min != null && root.GetData <= min.GetData) || (min != null && root.GetData > max.GetData))
                return false;

            if (IsBST(root.left, min, root) || !IsBST(root.GetRight, root, max))
                return false;

            return true;
        }

        BinaryTreNode _last = null;
        //public bool CheckIsBST(BinaryTreNode root)
        //{
        //    if (root == null)
        //        return true;

        //    if(!CheckIsBST(root.GetLeft))
        //    return false;

        //    if (_last != null && root.GetData <= _last.GetData)
        //        return false;

        //    _last = root;
           
        //    if (!CheckIsBST(root.GetRight))
        //        return false;

        //    return true;
        //}
    }
}
