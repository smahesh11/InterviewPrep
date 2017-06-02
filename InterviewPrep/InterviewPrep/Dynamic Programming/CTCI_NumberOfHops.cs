using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class NumberOfHops
    {
        public void count(int n)
        {
            int[] memo = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                memo[i] = -1;
            }

            GetHops(memo, n);
        }
        public int GetHops(int[] memo, int n )
        {
            
            if (n < 0)
                return -1;

            if (n == 0)
                return 1;   

            if (memo[n] > -1)
                return memo[n];

            memo[n] = GetHops(memo, n-1) +GetHops( memo,n - 2) + GetHops(memo, n - 3);

            return memo[n];
        }
    }
}
