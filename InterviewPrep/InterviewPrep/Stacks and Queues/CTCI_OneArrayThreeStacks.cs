using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Stacks_and_Queues
{
    public class OneArrayThreeStacks
    {
        int _stackcount = 3;
        int _stacksize = 10;
        int _arraysize = 0;
        int[] _array = null;
        int[] _CurrentSize = null;
        public OneArrayThreeStacks()
        {
            
            _arraysize = _stackcount * _stacksize;
            _array = new int[_arraysize];
           _CurrentSize  = new int[3];
        }
        public int Pop(int stackNum)
        {
            int pos = (stackNum * _arraysize) / 3 + _CurrentSize[stackNum];
            _CurrentSize[stackNum]--;
            return _array[pos];
        }

        public void Push(int stackNum, int data)
        {
            _CurrentSize[stackNum]++;
            int pos = (stackNum * _arraysize)/ 3 + _CurrentSize[stackNum];
            _array[pos] = data;
        }
    }
}
