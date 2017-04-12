using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Stacks_and_Queues
{
    public class QueueUsingTwoStacks
    {
        //Time Complexity : O(n)
        //Space Complexity : O(1)
        Stack S1 = new Stack();
        Stack S2 = new Stack();
        
        public void Add(int data)
        {
            S1.Push(data);
        }

        public Object Remove()
        {
            if (!S2.ifStackEmpty())
                return S2.Pop();

            while (!S1.ifStackEmpty())
            {
                S2.Push(S1.Pop());               
            }
            return S2.Pop();
        }

    }
}
