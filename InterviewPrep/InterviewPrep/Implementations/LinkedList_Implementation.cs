using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
    public class Node
    {
        public Node next;
        public Object data;

        public Node(Object data)
        {
            this.data = data;
        }
    }

    public partial class LinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddToFront(Object data)
        {
            Node newNode = new Node(data);

            newNode.data = data;
            newNode.next = head;

            head = newNode;
        }

        public void AddToRear(Object data)
        {
            if (head == null)
            {
                head = new Node(data);

                head.data = data;
                head.next = null;
            }
            else
            {
                Node toAdd = new Node(data);
                toAdd.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = toAdd;
            }
        }

   

        public void RemoveFromStart()
        {
            if(head != null && head.next!=null)
            {
                head.next = head.next.next;
            }          
        }
    }
}


