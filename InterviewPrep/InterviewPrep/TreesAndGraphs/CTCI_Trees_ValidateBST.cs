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

            if (IsBST(root.GetLeft, min, root) || IsBST(root.GetRight, root, max))
                return false;

            return true;
        }      


        public BinaryTreNode SearchInBST(BinaryTreNode root, int data)
        {
            if (root == null)
                return null;

            if (root.GetData == data)
                return root;

            if (data < root.GetData)
              return  SearchInBST(root.GetLeft, data);

            else
               return SearchInBST(root.GetRight, data);           
        }

        public BinaryTreNode InsertInBST(BinaryTreNode root, int data)
        {
            if (root == null)
            {
                root = new BinaryTreNode(data);
                return root;
            }      

             if (data < root.GetData)
             // root.GetLeft= 
					InsertInBST(root.GetLeft, data);

            else
				//root.GetRight = 
					InsertInBST(root.GetRight, data);

            return root;
        }

        public BinaryTreNode DeleteFromBST(BinaryTreNode root, int data)
        {
            if (root == null)
                return root;

            if (data < root.GetData)
                root.GetLeft = DeleteFromBST(root.GetLeft, data);
            if (data > root.GetData)
                root.GetRight = DeleteFromBST(root.GetRight, data);

            else
            {
                if (root.GetLeft == null)
                    return root.GetRight;

                if (root.GetRight == null)
                    return root.GetLeft;

                 root.GetData =  InOrderSucc(root.GetRight);    
                root.GetRight = DeleteFromBST(root.GetRight, root.GetData); 
            }

            return root;
        }

        public int InOrderSucc(BinaryTreNode root)
        {
            int min = root.GetData;
            while (root.GetLeft != null)
            {            
                min = root.GetLeft.GetData;
                root = root.GetLeft;
            }
            return min;
        }
        
    }
}
