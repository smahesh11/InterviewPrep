using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Stacks_and_Queues
{
    public class StacksMin
    {
       
       
        public int GetStackMin(Stack stack)
        {
            Stack minStack = new Stack();
            Stack _stack = stack; 
            int min = Int32.MaxValue;

            while (!_stack.ifStackEmpty())
            {
                int top = Convert.ToInt32(_stack.Pop());
                if (top < min)
                {
                    min = top;
                    minStack.Push(min);
                }
            }
            return Convert.ToInt32(minStack.Pop()); 

        }
        //public void push(int value)
        //{
        //    if (value <= Min())
        //        minStack.Push(value);
        //    _stack.Push(value);            
        //}

        //public int pop()
        //{
        //    int value = Convert.ToInt32(_stack.Pop());
        //    if (value == Min())
        //        minStack.Pop();
        //    return value;
        //}

        //public int Min()
        //{
        //    if (minStack.ifStackEmpty())
        //        return Int32.MaxValue;

        //    else return Convert.ToInt32(minStack.Peek());
        //}
    }
}
