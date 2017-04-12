using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Stacks_and_Queues
{
    class StackNode
    {
        public StackNode next;
        public Object data;

        public StackNode(Object data)
        {
            this.data = data;
        }
    }
    public partial class Stack
    {
        private StackNode top;

        public void Push(Object val)
        {
            StackNode node = new StackNode(val);
            node.next = top;
            top = node;
        }

        public Object Pop()
        {
            if(top==null)
            return null;

            Object item = top.data;
            top = top.next;

            return item;
        }

        public Object Peek()
        {
            if (top == null)
                return null;

            Object item = top.data;

            return item;
        }

        public bool ifStackEmpty()
        {
            if (top == null)
                return true;

            return false;
        }
    }
}
