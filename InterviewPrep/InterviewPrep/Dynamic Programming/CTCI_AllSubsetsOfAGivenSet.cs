using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class AllSubsets
    {
        public List<List<int>> GetAllSubsets(List<int> set, int index)
        {
            List<List<int>> allsubsets;

            if (set.Count == index)
            {
                allsubsets = new List<List<int>>();
                allsubsets.Add(new List<int>());
            }

            else
            {
                allsubsets = GetAllSubsets(set, index + 1);
                int item = set[index];
                List<int> newsubset;
                List<List<int>> more = new List<List<int>>();
                foreach (var subset in allsubsets)
                {
                    newsubset = new List<int>();
                    newsubset.AddRange(subset);
                    newsubset.Add(item);
                    more.Add(newsubset);
                }
                allsubsets.AddRange(more);
            }

            return allsubsets;

        }
    }
}
