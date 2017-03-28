using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
    public partial class LinkedList
    { 
      public  bool IsPalindrome()
        {
            Node current = head;
            Stack<Object> st = new Stack<Object>();
            while (current != null)
            {               
                st.Push(current.data);
                current = current.next;
            }

            current = head;
            while (current != null)
            {
                if (st.Pop() != current.data)
                    return false;

                current = current.next;
            }

            return true;
        }
    }
}