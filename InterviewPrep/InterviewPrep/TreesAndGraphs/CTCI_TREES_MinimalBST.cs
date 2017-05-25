using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class MinimalBST
    {
        public BinaryTreNode CreateMinimalBST(int[] array, int start, int end)
        {
            if (end < start)
                return null;

            int mid = (start+end)/2;
            BinaryTreNode root =  new BinaryTreNode(array[mid]);
            root.GetLeft = CreateMinimalBST(array, start, mid-1);
            //Console.WriteLine(root.left.GetData);            
            root.GetRight = CreateMinimalBST(array, mid+1, end);
            // Console.WriteLine(root.right.GetData);

            //Console.WriteLine(root.GetData);
            return root;

        }
    }
}
