using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
    public partial class LinkedList
    {
        public Node PartitionLinkedList(int value)
        {
            //given is linkedlist and value to partition
            Node newNode = new Node(5);
            Node head1 = newNode;
            Node tail = newNode;

            Node node = head;

            while (node != null)
            {
                Node next = node.next;

                if (Convert.ToInt32(node.data) <= value)
                {
                    node.next = head1;
                    head1 = node;
                }

                else
                {
                    tail.next = node;
                    tail=node;
                }
                node = next;
            }
            tail.next = null;       
          
            return head;
        }
    }
}
