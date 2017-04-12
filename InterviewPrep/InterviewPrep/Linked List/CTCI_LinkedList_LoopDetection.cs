using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
   public class DetectLoop
    {
        public Node LoopDetection(Node head)
        {
            //p1 moves 1 step, p2 moves 2 steps
            Node p1 = head;
            Node p2 = head;

            while (p2!= null && p2.next!=null)
            {
                p1 = p1.next;
                p2 = p2.next.next;
                if (p1 == p2)
                    break;
            }

            if (p2 == null && p2.next == null)
            {
                return null; // No Loop
            }

            p1 = head;

            while (p1 != p2)
            {
                p1 = p1.next;
                p2 = p2.next;
            }
            return p1;
        }
    }
}
