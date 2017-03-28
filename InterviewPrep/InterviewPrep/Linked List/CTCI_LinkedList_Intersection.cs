using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
    public  class Intersection{

         public Node doIntersects(Node head1, Node head2)
        {

            Node node1 = head1;
            int size1 = 0;
            while (node1 != null)
            {
                node1 = node1.next;
                size1++;
            }

            Node node2 = head2;
            int size2 = 0;
            while (node2 != null)
            {
                node2 = node2.next;
                size2++;
            }
            if (node1 != node2)
                return null;

            int diff = Math.Abs(size1 - size2);
          
            Node longerHead = null;
            if (size1 > size2)
                head1= TrimLonger(head1, diff);

            else if(size1 < size2)
                 head2= TrimLonger(head2, diff);

            node1 = head1; node2 = head2;

            while ( node1!= null)
            {
                if (Convert.ToInt32(node1.data) == Convert.ToInt32(node2.data)) 
                return node1;

                node1 = node1.next;
                node2 = node2.next;
            }
            return node1;
        }

        public Node TrimLonger(Node longerHead, int diff)
        {
            for (int i = 0; i < diff; i++)
            {
                longerHead = longerHead.next;
            }
            return longerHead;
        }

    }
}
