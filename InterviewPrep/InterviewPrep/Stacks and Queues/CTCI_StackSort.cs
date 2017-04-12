using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Stacks_and_Queues
{
    class StackSort
    {
        public Stack Sort(Stack s1)
        {
            Stack s2 = new Stack();

           
            //int temp = Convert.ToInt32(s1.Pop());
            while (!s1.ifStackEmpty())
            {
                int temp = Convert.ToInt32(s1.Pop());
                //s2.Push(s1.Pop());
                while (!s2.ifStackEmpty() && Convert.ToInt32(s2.Peek()) > temp)
                {
                    s1.Push(s2.Pop());
                }
                s2.Push(temp);
            }

            while (!s2.ifStackEmpty())
            {
                s1.Push(s2.Pop());
            }
          return s1;
        }
    }
}
