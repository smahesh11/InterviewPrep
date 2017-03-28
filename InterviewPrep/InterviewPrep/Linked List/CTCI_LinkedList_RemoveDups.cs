using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
    public partial class LinkedList
    {
        public void RemoveDups_usingBuffer()
        {
            //TimeComplexity : O(n)
            //Space Complexity : O(n)
            Node current = head;
            Dictionary<Object, int> freq = new Dictionary<Object, int>();
            Node previous = null;
            while (current != null)
            {
                if (freq.ContainsKey(current.data))
                {
                    previous.next = current.next;
                }
                else
                {
                    freq.Add(current.data, 1);
                    previous = current;
                }
                    current = current.next;
            }            
        }

        public void RemoveDups_withoutBuffer()
        {
            //TimeComplexity : O(1)
            //Space Complexity : O(n)
            Node current = head;
            while (current != null)
            {
                Node tracker = current;

                while (tracker.next != null)
                {
                    if (current.data==tracker.next.data)
                    {
                        tracker.next = tracker.next.next;
                    }
                    else tracker = tracker.next;
                }
                current = current.next;
            }
        }
    }
}
