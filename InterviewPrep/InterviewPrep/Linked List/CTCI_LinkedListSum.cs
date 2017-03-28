using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Linked_List
{
    public class LinkedListSum
    {
        public Node1 Sum(Node1 head1, Node1 head2)
        {

            Node1 number1 = head1;
            Node1 number2 = head2;
            
            CalculateSum(head1, head2, 0);

            Node1 resultHead = new Node1();

            return null;

        }

        public Node1 CalculateSum(Node1 num1, Node1 num2, int carry)
        {            
            int value = 0;
            int nodeSum = 0;

            Node1 res = new Node1();

            if(num1!=null)
             nodeSum += num1.data;

            if (num2 != null)
                nodeSum += num2.data;

            nodeSum += carry;

            carry = nodeSum /10;
            value = nodeSum % 10;           

            if (num1== null && num2== null && carry== 0)
                return null;

            if (num1 != null)
                num1 = num1.next;
            else num1 = null;

            if (num2 != null)
                num2 = num1.next;
            else num2 = null;

            res= CalculateSum(num1.next, num2.next, carry);                    

            return res;
        }
    }

    public class Node1
    {
        public Node1 next;
        public int data;
        public Node1()
        { }

        public Node1(int data)
        {
            this.data = data;
        }
    }

    public partial class LinkedList1
    {
        private Node1 _head;   
    }
}
