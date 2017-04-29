using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
     public class ListOfNodesAtEachLevel
    {
        public Dictionary<int, List<BinaryTreNode>> GetList(BinaryTreNode root)
        {
            Dictionary<int, List<BinaryTreNode>> dict = new Dictionary<int, List<BinaryTreNode>>();
            int level = -1;
            List<BinaryTreNode> levelList = new List<BinaryTreNode>();
           // = new List<BinaryTreNode>();
            if (root!= null)
            { 
                levelList.Add(root);
            }
           
            while (levelList.Count > 0)
            {
                level++;
                List<BinaryTreNode> parents = levelList;
                dict.Add(level, parents);
                levelList = new List<BinaryTreNode>();

                foreach (BinaryTreNode p in parents)
                {
                    if (p.GetLeft != null) levelList.Add(p.GetLeft);
                    if (p.GetRight != null) levelList.Add(p.GetRight);
                }
               // level++;
                // dict.Add(level, levelList);             
            }

            return dict;
        }
        
    }
}
