using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
     public class CheckIsTreeBalanced
    {
        public int  GetTreeHight(BinaryTreNode root)
        {
            if (root == null)
                return -1;
           
            int leftHeight = GetTreeHight(root.left);
            if (leftHeight == int.MinValue)
                return int.MinValue;
                 
            int rightHeight = GetTreeHight(root.right);
            if (rightHeight == int.MinValue)
                return int.MinValue;
            int diff = Math.Abs(leftHeight - rightHeight);

            if (diff > 1)
                return int.MinValue;

            else return Math.Max(leftHeight,rightHeight)+1;               
             
        }

        public bool isBalanced(BinaryTreNode root)
        {
           // int diff = Math.Abs(GetTreeHight(root.left) - GetTreeHight(root.right));

            if (GetTreeHight(root) == int.MinValue)              return false;
            else return true;

        }
       
    }
}
