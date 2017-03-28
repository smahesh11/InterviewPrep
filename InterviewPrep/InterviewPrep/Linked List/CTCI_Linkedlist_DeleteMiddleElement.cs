using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
    public partial class LinkedList
    {
        public void DeleteMiddleNode()
        {
            if(head!=null  && head.next!=null)
                head.next = head.next.next;
            //    Node current = head.next;
            //    head.data = current.data;
            //    node.next = current.next;


        }
    }
}
