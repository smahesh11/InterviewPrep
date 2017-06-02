using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class MultiplyTwoNumbers
    {

        public int MultiplyMain(int num1, int num2)
        {
            int small=num1; int big=num2;
            if (num1 >= num2)
            {
                small = num2;
                big = num1;
            }
            int[] memo = new int[small + 1];
            return Multiply(small, big, memo);                
        }

        public int Multiply(int small, int big, int[] memo)
        {
            if (small == 0)
                return 0;

            if (small == 1)
                return big;

            if(memo[small]>0)
                return memo[small];

            int s = small / 2;
            int s1 = Multiply(s, big, memo);
            int s2;
            if (small % 2 == 0)
            {
                s2 = s1;
            }

            else s2 = Multiply(small - s, big, memo);

            return memo[small] = s1 + s2;
        }
    }
}
