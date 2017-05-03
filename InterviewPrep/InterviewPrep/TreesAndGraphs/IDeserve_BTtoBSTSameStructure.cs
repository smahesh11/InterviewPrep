using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class BTtoBSTSameStructure
    {
        List<int> inorder = new List<int>();
        public BinaryTreNode ToBST(BinaryTreNode root)
        {
            int[] index = new int[1];
          
            ConvertToInorder(root, inorder, index);

            inorder.Sort();
            index[0] = 0;

            ReplaceNodes(root, inorder, index);

            return root;
        }

        public void ConvertToInorder(BinaryTreNode curr, List<int> inorder, int[] index)
        {
            if (curr == null)
                return;

            ConvertToInorder(curr.GetLeft, inorder, index);
            inorder.Add(curr.GetData);
            index[0]++;
            ConvertToInorder(curr.GetRight, inorder, index);
        }

        public void ReplaceNodes(BinaryTreNode curr, List<int> inorder, int[] i)
        {
            if (curr == null)
                return;

            ReplaceNodes(curr.GetLeft, inorder, i);

            curr.GetData = inorder[i[0]];
            i[0] += 1;

            ReplaceNodes(curr.GetRight, inorder, i);
        }
    }


}