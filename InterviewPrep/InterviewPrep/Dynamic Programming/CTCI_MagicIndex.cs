using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class MagicIndex
    {
        public int GetMagicIndex(int[] arr, int start, int end)
        {
            if (start > end)
                return -1;
            int mid = (start+end)/ 2;

            if (arr[mid] == mid)
                return mid;
    
            int midval = arr[mid];

            int left = GetMagicIndex(arr, Math.Min(midval, mid - 1), end);
            if (left >= 0)
                return left;

            int right = GetMagicIndex(arr, Math.Min(midval, mid + 1), end); ;
            return right; 
            
        }
    }
}
