using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class IfHasOnlyOneChildPerNode
    {
        public bool CheckIfOnlyOneChild(int[] array)
        {
            int max = array[array.Length - 1];
            int min = array[array.Length - 1];

            for (int i = array.Length - 2; i >= 0; i--)
            {
                if ((array[i] < max) && array[i] > min)
                    return false;

                else
                {
                    max = Math.Max(array[i], max);
                    min = Math.Min(array[i], min);
                }
            }
            return true;           
        }
    }
}
