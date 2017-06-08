using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class CTCI_CoinSum
    {
        public void MakeChange(int amount)
        {
            int[] denoms = new int[] {1, 5, 10, 25 };
            int[,] map = new int[amount + 1,denoms.Length];
            MakeChange(amount, denoms, 0, map);
        }

        public int MakeChange(int amount, int[] denoms, int index, int[,] map)
        {   if (map[amount,index] > 0)
                return map[amount,index];

            if (index >= denoms.Length-1)
                return 1;

            int ways = 0;

            int denoVal = denoms[index];
            for (int i = 0; i * denoVal < amount; i++)
            {
              int rem = amount - (i * denoVal);
              ways +=  MakeChange(rem, denoms, i+1, map);               
            }
            map[amount, index] = ways;
            return ways;
        }
    }
}
