using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Stacks_and_Queues
{
    class QueueNode
    {
        public QueueNode next;
        public Object data;

        public QueueNode(Object data)
        {
            this.data = data;
        }
    }

    public partial class Queue
    {
        private QueueNode front;
        private QueueNode rear;

        public void Add(Object val)
        {
            QueueNode node = new QueueNode(val);
            if (rear != null)
                rear.next = node;
            rear = node;

            if (front == null)
                front = rear;
        }

        public Object Delete()
        {
            if (front == null)
                return null;

            Object item = front.data;
            front = front.next;

            if (front == null)
            {
                rear = null;
            }

            return item;
        }

        public Object Peek()
        {
            if (front == null)
                return null;

            Object item = front.data;

            return item;
        }

        public bool ifQueueEmpty()
        {
            if (front == null && rear == null)
                return true;

            return false;
        }
    }
}