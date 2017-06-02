using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Implementations
{

    public class DoublyLinkedList
    {
        public DLLNode head;
        public DLLNode tail;
        int count;

        public DoublyLinkedList()
        {
            count = 0;
        }
        public void AddFirst(int value)
        {
            DLLNode tmp = new DLLNode(value, head, null);
            if (head != null)
            {
                head.prev = tmp;
            }
            head = tmp;
            if (tail == null)
            {
                tail = tmp;
            }
            count++;
        }

        public void AddLast(int value)
        {
            DLLNode node = new DLLNode(value, null, tail);

            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;

            if (head == null)
            {
                head = node;
            }

            count++;
        }

        public void Moveforth()
        {
            DLLNode node = head;
            while (node != null)
            {
                node = node.next;
            }
        }

        public void Moveback()
        {
            DLLNode node = tail;

            while (node != null)
            {
                node = node.prev;
            }
        }

        public void RemoveFirst()
        {
            if (count == 0)
                return;
            head = head.next;
            head.prev = null;
            count--;
        }

        public void RemoveLast()
        {
            if (count == 0)
                return;
            tail = tail.prev;
            tail.next = null;
            count--;
        }
    }

    public class DLLNode
    {
        public int value;
        public DLLNode prev;
        public DLLNode next;

        public DLLNode()
        { }

        public DLLNode(int value)
        {
            this.value = value;
        }
        public DLLNode(int value, DLLNode prev, DLLNode next)
        {
            this.value = value;
            this.prev = prev;
            this.next = next;
        }

    }
}
