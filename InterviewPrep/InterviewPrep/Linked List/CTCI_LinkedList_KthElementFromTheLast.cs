using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
    public partial class LinkedList
    {
        public Object KthElementFromLast(int k)
        {
            Node p1 = head;
            Node p2 = head;

            int i = 0;
            while (i < k && p1!=null)
            {
                p1 = p1.next;
                i++;
            }

            while (p1 != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }
            return p2.data;
        }
    }
}
