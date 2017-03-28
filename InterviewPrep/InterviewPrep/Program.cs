using InterviewPrep.Arrays_and_Strings;
using InterviewPrep.Linked_List;
using InterviewPrep.Stacks_and_Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            #region Ispermutation
            /*
             // Check if on estring is permutation of the other
             CTCICheckPermutation obj = new CTCICheckPermutation();
             Console.WriteLine(obj.isPermutation("-654@", "@-645"));

             //Console.ReadLine();
             //Pass cases: "Hello" "lohle" , "1234" "4213" , "-654@" "7-46@5", "", "" 
             //Fail cases: "Hello""Hell", "4213" "-654@", 
             //Hck cases: "Hello" "null"
             // "Hello" "lohle" "Hell" "1234" "4213" "-654@" "7-46@5" "Rev"

             //Console.WriteLine(obj.isPermutation("Hello", "Heoll")); // F
             //Console.WriteLine(obj.isPermutation("Hello", "lohle")); // T
             //Console.WriteLine(obj.isPermutation("1234", "4213")); // T
             //Console.WriteLine(obj.isPermutation("-654@", "7-46@5")); // F
             //Console.WriteLine(obj.isPermutation("Hello", "")); //F
             //Console.WriteLine(obj.isPermutation("Hello", null)); // F
             //Console.WriteLine(obj.isPermutation(null, ""));  // F
             //Console.WriteLine(obj.isPermutation("", "")); //F
             //Console.WriteLine(obj.isPermutation(null, null)); //F
           // */

            #endregion Ispermutation


            #region IsUniqueChars    
            /*
              // Check if a string contains all unique characters
             CTCIIsAllUniqueChars obj = new CTCIIsAllUniqueChars();
             Console.WriteLine(obj.IsUnique_One("Hello"));
             Console.WriteLine(obj.IsUnique_Two("Shweta"));
             //Console.WriteLine(obj.IsUnique_One(""));
             //Console.WriteLine(obj.IsUnique_Two(null));

             //Pass Case: "Shweta" , "water dump", "a", "1", "-", " ", "
             //Fail Case: "Hello", "waterbottle"," a  b"
             //Hack Case: "" , null
             */
            #endregion IsUniqueChars


            #region isRotationString

            /*
              //Check if one string is rotation of other
             CTCIIsRotation isrotaion = new CTCIIsRotation();
             Console.WriteLine(isrotaion.isRotation("12345","52143"));

             //Pass Case: "waterbottle" "erbottlewat" , "aaaaa" "aaaaa", "aaaa" "bbbb"
             //Fail Case: "Hello"  "waterbottle", "" "abc"
             //Hack Case: "" , null
             // */
            #endregion

            #region URLify
            /*
              //Check if one string is rotation of other
             Console.WriteLine(URLify.stringUrlify("Mr John Smith    ", 13));
             Console.WriteLine(URLify.stringUrlify("", 0));

             //Pass Case: "Mr John Smith    " , "   "
             //Fail Case: "Mr John Smith"  "", "" "abc"
             //Hack Case: "" , null
             string str = "";
             Console.WriteLine(str.Length);
             */
            #endregion


            #region MatrixZeroing
            /*  int[][] mat = new int[4][]
              {
                  new int[] { 1, 6, 3, 4 },
                  new int[] { 6, 7, 5, 2 },
                  new int[] { 0, 3, 2, 8 }, 
                  new int[] { 9, 7, 6, 5 } };
            //  MatrixRowsandColumnsZeroed.MatrixNullify1(mat);
              CTCIMatrixRowsandColumnsZeroed.MatrixNullify2(mat);

              //Pass case : {{ 1, 6, 3}, { 6, 7, 5}, { 0, 3, 2}}
              //Fail case: null, {{ 1, 6, 3}, { 6, }, { 0, 2}}
              //Hack Case: null
              //*/
            #endregion

            #region charactercount
            /*
           Console.WriteLine(CTCICharacterCount_a2b3.GenerateNewString("aabbbcdddd"));
           Console.WriteLine(CTCICharacterCount_a2b3.GenerateNewString("shweta"));
           Console.WriteLine(CTCICharacterCount_a2b3.GenerateNewString(null));
           Console.WriteLine(CTCICharacterCount_a2b3.GenerateNewString("    "));

           //Pass case : "aabbbcdddd"- a2b3c1d4,  "shweta- s1h1w1e1t1a1"
           //Fail case: null, ""}  "    " -. 4 
           //Hack Case: null
           // */
            #endregion charactercount

            #region IsOneAway
            /*
            Console.WriteLine(CTCIOneAway.isOneAway("abcd", "abcd"));// Pass
            Console.WriteLine(CTCIOneAway.isOneAway("shweta", "shwet")); // Pass
            Console.WriteLine(CTCIOneAway.isOneAway("helo", "hello")); // Pass
            Console.WriteLine(CTCIOneAway.isOneAway("hale", "pale")); // Pass
            Console.WriteLine(CTCIOneAway.isOneAway("hale", "bake")); //Fail
            Console.WriteLine(CTCIOneAway.isOneAway("", null)); //Fail
            Console.WriteLine(CTCIOneAway.isOneAway("", "a")); //Fail

            //Pass case : {"abcd", "abcd"}, { "shweta", "shwet"}, {"helo", "hello"}, {"hale", "pale"}
            //Fail case: {null, "" } ,{ "hale", "bake"}, {null, null}, {"",""}
            //Hack Case: null
            // */
            #endregion IsOneAway

            #region IsPalindromePermutation
            /*
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("tact coa"));// Fail
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("abcbac"));// Pass
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("bgf gkl flbk"));// Pass
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("bgf shjsg"));// Fail
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("tact cota"));// Fail
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("saddas assddasa"));// Fail
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation(""));// Hack
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation(null));// Hack


            //Pass case : {"abcd", "abcd"}, { "shweta", "shwet"}, {"helo", "hello"}, {"hale", "pale"}
            //Fail case: {null, "" } ,{ "hale", "bake"}, {null, null}, {"",""}
            //Hack Case: null
            // */
            #endregion IsPalindromePermutation

            #endregion Arrays

            #region LinkedList

            #region LinkedList Strings

            //Console.WriteLine("Add First:");
            //LinkedList LL1 = new LinkedList();

            //LL1.AddToFront("Hello");
            //LL1.AddToFront("Magical");
            //LL1.AddToFront("World");

            //Console.WriteLine();

            //// Console.WriteLine("Add Last:");
            //// LL1.AddToRear("abc");
            //LL1.AddToFront("shweta");
            //LL1.AddToFront("World");
            //LL1.AddToFront("Magical");
            //LL1.AddToFront("Hello");

            //LL1.AddToRear("Shia");
            //LL1.AddToRear("Shweta");
            //LL1.AddToRear("smahesh");
            //LL1.printAllNodes();
            Console.WriteLine();
            //*/
            #region Remove dups without buffer

            //LL1.RemoveDups_withoutBuffer();                  
            // LL1.printAllNodes();
            // Console.WriteLine();
            // 
            #endregion

            #region Remove dups using buffer
            /*
                 LL1.RemoveDups_usingBuffer();
                 LL1.printAllNodes();
                 Console.WriteLine();
           // */
            #endregion

            #region  Kth Element from last
            /* 
                Console.WriteLine("Kth Element from Last :");
                Console.WriteLine(LL1.KthElementFromLast(3).ToString());
                Console.WriteLine();  
            // */
            #endregion

            #region Delete Middle Node
            /*
                 LL1.DeleteMiddleNode();
                 Console.WriteLine();
                 Console.WriteLine("After Deleting Middle Node");
                 LL1.printAllNodes();
                 Console.WriteLine();
             // */
            #endregion

            #region Palindrome
            //    Console.WriteLine("Strings : "+LL1.IsPalindrome());
            #endregion Palindrome

            #endregion LinkedList String

            #region LinkedList Int
            /*
             LinkedList LL2 = new LinkedList();
             LL2.AddToFront(2);
             LL2.AddToFront(7);
             LL2.AddToFront(8);
             LL2.AddToFront(5);
             LL2.AddToFront(3);
             LL2.AddToFront(10);
             LL2.AddToFront(1);
             LL2.AddToFront(4);

             Console.WriteLine("LinkedList:");
             LL2.printAllNodes();

             Console.WriteLine();
             Console.WriteLine("LinkedList after partition:");
             Node head= LL2.PartitionLinkedList(5);

         while (head.next != null)
         {
             Console.Write(head.data);
             head = head.next;
         }
             LL2.printAllNodes();
             // */
            #endregion LinkedList Int                     

            #region LinkedList Intersection
            /*
            Node head1 = new Node(5);
            head1.next = new Node(6);
            head1.next.next = new Node(7);
            head1.next.next.next = new Node(3);
            head1.next.next.next.next = new Node(2);
            Node head2 = new Node(4);
            head2.next = new Node(8);
            head2.next.next = new Node(3);
            head2.next.next.next = new Node(2);
            Intersection intersection = new Intersection();
            Node res=intersection.doIntersects(head1, head2);
            Console.WriteLine(res.data);
           // */
            #endregion LinkedList Loopdetection

            #region LinkedList Loop Detection
            /*
            Node head = new Node(5);
            head.next = new Node(6);
            head.next.next = new Node(7);
            head.next.next.next = new Node(9);
            head.next.next.next.next = new Node(2);
            head.next.next.next.next.next = head.next.next.next;

            DetectLoop isLoop = new DetectLoop();
            Node res = isLoop.LoopDetection(head);
            Console.WriteLine("Loop starts at: " + res.data);
            // */
            #endregion LinkedList Loopdetection

         
            #region LinkedList Sum
            Node1 head1 = new Node1(5);
            head1.next = new Node1(6);
            head1.next.next = new Node1(7);

            Node1 head2 = new Node1(4);
            head2.next = new Node1(2);
            head2.next.next = new Node1(3);

            LinkedListSum llSum = new LinkedListSum();
            Node1 res = llSum.Sum(head1, head2);
            #endregion LinkedList Sum

            #endregion Linked List


            #region Stacks
            /*
                Stack stack = new Stack();
                stack.Push(7);
                stack.Push(4);
                stack.Push(1);
                stack.Push(9);
                stack.Push(2);
                stack.Push(8);
                stack.Push(7);
                stack.Push(3);
                stack.Push(2);

                while (!stack.ifStackEmpty())
                {
                    Console.WriteLine(stack.Pop());
                }
            // */
            #endregion Stacks
          
            #region Queues
            /*
                Queue queue = new Queue();
                queue.Add(7);
                queue.Add(4);
                queue.Add(1);
                queue.Add(9);
                queue.Add(2);
                queue.Add(8);
                queue.Add(7);
                queue.Add(3);
                queue.Add(2);

                while (!queue.ifQueueEmpty())
                {
                    Console.WriteLine(queue.Delete());
                }
              // */
            #endregion queues
            Console.ReadLine();

            #region Trees and Graphs
            #region Trees
           
            //List<Object> obj = new List<Object>();
            //obj.Add(1);
            //obj.Add(2);
            //obj.Add(3);
            //obj.Add(4);
            //obj.Add(5);
           
            #endregion
            #endregion Trees and Graphs
        }

    }
}
