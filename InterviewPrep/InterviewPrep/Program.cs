using InterviewPrep.Arrays_and_Strings;
using InterviewPrep.Linked_List;
using InterviewPrep.Stacks_and_Queues;
using InterviewPrep.TreesAndGraphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewPrep.Sorting_and_Searching;
using InterviewPrep.Dynamic_Programming;
using InterviewPrep.Implementations;
using InterviewPrep.Misc;

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

			#region DiagonalOfMatrix
			/*
			PrintMatrixDiagonally pt = new PrintMatrixDiagonally();
			int[][] mat = new int[5][]
			 {
				  new int[] { 1, 6, 3, 4 },
				  new int[] { 6, 7, 5, 2 },
				  new int[] { 0, 3, 2, 8 },
				  new int[] { 9, 7, 6, 5 },
				  new int[] { 10, 11, 12, 13 }};

			pt.Print(mat);
			// */
			#endregion

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
			/*
            Node1 head1 = new Node1(5);
            head1.next = new Node1(6);
            head1.next.next = new Node1(7);

            Node1 head2 = new Node1(4);
            head2.next = new Node1(2);
            head2.next.next = new Node1(3);

            LinkedListSum llSum = new LinkedListSum();
            Node1 res = llSum.Sum(head1, head2);
            // */
			#endregion LinkedList Sum

			#endregion Linked List

			#region Stacks
			/*
                Stack stack = new Stack();
                stack.Push(7);
                stack.Push(47);
                stack.Push(1);
                stack.Push(9);
                stack.Push(2);
                stack.Push(15);
                stack.Push(7);
                stack.Push(3);
                stack.Push(7);

            //while (!stack.ifStackEmpty())
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            // */
			#region StackMin
			/*
             StacksMin stkMin = new StacksMin();
             Console.WriteLine(stkMin.GetStackMin(stack));
             Console.WriteLine();
             while (!stack.ifStackEmpty())
             {
                 Console.WriteLine(stack.Pop());
             }
             // */
			#endregion



			#region StackSort
			/*
            StackSort sort = new StackSort();
            stack = sort.Sort(stack);
            while (!stack.ifStackEmpty())
            {
                Console.WriteLine(stack.Pop());
            }
            // */
			#endregion

			#region OneArrayThreeStacks
			/*
            OneArrayThreeStacks stacksArray = new OneArrayThreeStacks();
            stacksArray.Push(0,5);
            stacksArray.Push(0, 4);
            stacksArray.Push(0, 2);
            stacksArray.Push(1, 8);
            stacksArray.Push(1, 3);
            stacksArray.Push(1, 9);
            stacksArray.Push(2, 0);
            stacksArray.Push(2, 1);
            stacksArray.Push(2, 2);
            stacksArray.Push(2, 11);

            for (int i=0;i<3;i++)
                Console.Write(stacksArray.Pop(0));
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
                Console.Write(stacksArray.Pop(1));
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
                Console.Write(stacksArray.Pop(2));
            Console.WriteLine();
            // */
			#endregion

			#region AnimalShelter

			#endregion

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

			#region QueueUsing2 Stacks
			/*
            QueueUsingTwoStacks q = new QueueUsingTwoStacks();
            q.Add(5);
            q.Add(7);
            q.Add(2);

            Console.WriteLine(q.Remove());
            Console.WriteLine(q.Remove());
            Console.WriteLine(q.Remove());
            // */
			#endregion

			#region AnimalShelter
			/*
            AnimalShelter shelter = new AnimalShelter();
            shelter.AddAnimal("Cat");
            shelter.AddAnimal("Dog");
            shelter.AddAnimal("Cat");
            shelter.AddAnimal("Cat");
            shelter.AddAnimal("Dog");
            shelter.AddAnimal("Dog");
            Console.WriteLine(shelter.BuyAnyAnimal()._type);
            Console.WriteLine(shelter.BuyCat()._type);
            Console.WriteLine(shelter.BuyDog()._type );
            // */
			#endregion

			#endregion queues
			#region Trees and Graphs
			#region Trees 1
			//Tree<Int32> trees = new Tree<Int32>();

			//List<BinaryTreeNode<Int32>> treenodeNeighbor1 = new List<BinaryTreeNode<Int32>>();
			//List<BinaryTreeNode<Int32>> treenodeNeighbor2 = new List<BinaryTreeNode<Int32>>();
			//List<BinaryTreeNode<Int32>> treenodeNeighbor3 = new List<BinaryTreeNode<Int32>>();
			//List<BinaryTreeNode<Int32>> treenodeNeighbor4 = new List<BinaryTreeNode<Int32>>();
			//List<BinaryTreeNode<Int32>> treenodeNeighbor = new List<BinaryTreeNode<Int32>>();

			//treenodeNeighbor1.Add(new BinaryTreeNode<Int32>(1, null));
			//treenodeNeighbor1.Add(new BinaryTreeNode<Int32>(2, null));

			//var treeNode1Array = treenodeNeighbor1.ToArray();
			//var treeNode2Array = treenodeNeighbor2.ToArray();

			//treenodeNeighbor2.Add(new BinaryTreeNode<Int32>(3, null));
			//treenodeNeighbor2.Add(new BinaryTreeNode<Int32>(4, null));

			//BinaryTreeNode<Int32> treenode1 = new BinaryTreeNode<Int32>(10, treenodeNeighbor1.ToArray());
			//BinaryTreeNode<Int32> treenode2 = new BinaryTreeNode<Int32>(20, treenodeNeighbor2.ToArray());

			//List<BinaryTreeNode<Int32>> treenodeNeighbor5 = new List<BinaryTreeNode<Int32>>();
			//treenodeNeighbor5.Add(treenode1);
			//treenodeNeighbor5.Add(treenode2);

			//BinaryTreeNode<Int32> root = new BinaryTreeNode<Int32>(100, treenodeNeighbor5.ToArray());

			//trees.InOrderTraversal(root);
			//trees.PreOrderTraversal(root);
			//trees.PostOrderTraversal(root);
			#endregion

			#region MinimalBST
			/*
			 BinaryTree bt = new BinaryTree();
            int[] arr = new int[7];
            arr[0] = 1; arr[1] = 2; arr[2] = 3; arr[3] = 4; arr[4] = 5; arr[5] = 6; arr[6] = 7;
            MinimalBST minBST = new MinimalBST();
            bt.InOrderTraversal(minBST.CreateMinimalBST(arr, 0, 6));
            // */
			#endregion

			#region Binary Tree  implementation left right 
			/*			
			BinaryTreNode root = new BinaryTreNode(6);
			root.GetLeft = new BinaryTreNode(4);
			root.GetRight = new BinaryTreNode(10);

			root.GetLeft.GetLeft = new BinaryTreNode(2);
			root.GetLeft.GetRight = new BinaryTreNode(6);
			root.GetRight.GetLeft = new BinaryTreNode(9);
			root.GetRight.GetRight = new BinaryTreNode(11);
			root.GetLeft.GetRight.GetLeft = new BinaryTreNode(5);
			root.GetLeft.GetRight.GetRight = new BinaryTreNode(7);
			root.GetLeft.GetLeft.GetLeft = new BinaryTreNode(1);
			root.GetLeft.GetLeft.GetRight = new BinaryTreNode(3);
			// */

			#region Tree Traversal
			//BinaryTree bt = new BinaryTree();
			//bt.InOrderTraversal(root);
			//bt.PreOrderTraversal(root);
			//bt.PostOrderTraversal(root);
			Console.WriteLine();
			//bt.IterativePreOrderTraversal(root);
			#endregion

			#region LeastCommonAncestor
			// LeastCommonancestor2 lca = new LeastCommonancestor2();
			// Console.WriteLine(lca.LeastCommonAncestor(root, root.left.left, root.left.right.right).GetData);
			//BinaryTreNode btn = new BinaryTreNode(root.GetData);
			//Console.WriteLine(btn.GetParent(root, root.GetLeft.GetRight.GetRight).GetData);
			#endregion

			#region IsBalanced
			/*
            CheckIsTreeBalanced itb = new CheckIsTreeBalanced();
            //Console.WriteLine(itb.isBalanced(root));
            // */
			#endregion

			#region IsSubtree
			/*
            IsSubtree isSub = new IsSubtree();
             Console.WriteLine(isSub.isTreeSubtree(root, root.left.left));
            // */
			#endregion

			#region spiralWithStacks
			/*
			IDeserve_SpiralTree spiral = new IDeserve_SpiralTree();
			spiral.PrintSpiralTreeWithStacks(root);
			//*/
			#endregion

			#region spiralNoStacks
			/*
			IDeserve_SpiralTree spiral = new IDeserve_SpiralTree();
			spiral.PrintSpiralTreeNoBuffer(root);			
			//*/
			#endregion

			#region BT to BST
			/*
			BTtoBSTSameStructure bst = new BTtoBSTSameStructure();
			 bst.ToBST(root);
			BinaryTree bt = new BinaryTree();
			bt.InOrderTraversal(root);

			//*/
			#endregion

			#region IsSymmetrical BinaryTree
			/*
			BinaryTreNode root = new BinaryTreNode(6);
			root.GetLeft = new BinaryTreNode(4);
			root.GetRight = new BinaryTreNode(4);

			root.GetLeft.GetLeft = new BinaryTreNode(2);
			root.GetLeft.GetRight = new BinaryTreNode(4);
			root.GetRight.GetLeft = new BinaryTreNode(4);
			root.GetRight.GetRight = new BinaryTreNode(2);
			root.GetRight.GetRight.GetLeft = new BinaryTreNode(5);
			root.GetRight.GetRight.GetRight = new BinaryTreNode(7);
			root.GetLeft.GetLeft.GetLeft = new BinaryTreNode(7);
			root.GetLeft.GetLeft.GetRight = new BinaryTreNode(5);

			IssSymmetricalBinaryTree isSym = new IssSymmetricalBinaryTree();

			Console.WriteLine(isSym.IsSymmetrical(root, root));
			// */
			#endregion

			#region ValidateBST
			/*
            ValidateBST bst = new ValidateBST();
            Console.WriteLine(bst.CheckIsBST(root));
            // */
			#endregion


			#region isSubtree 2

			//BinaryTreNode root1 = new BinaryTreNode(6);
			//root1.GetLeft = new BinaryTreNode(2);
			//root1.GetRight = new BinaryTreNode(4);

			//root1.GetLeft.GetLeft = new BinaryTreNode(9);
			//root1.GetLeft.GetRight = new BinaryTreNode(8);
			//root1.GetRight.GetLeft = new BinaryTreNode(7);
			//root1.GetRight.GetRight = new BinaryTreNode(6);

			//BinaryTreNode root2 = new BinaryTreNode(2);
			//root2.GetLeft = new BinaryTreNode(9);
			//root2.GetRight = new BinaryTreNode(8);
			BinaryTreNode root = new BinaryTreNode(8);
			root.GetLeft = new BinaryTreNode(4);
			root.GetRight = new BinaryTreNode(10);

			root.GetLeft.GetLeft = new BinaryTreNode(2);
			root.GetLeft.GetRight = new BinaryTreNode(6);
			root.GetRight.GetLeft = new BinaryTreNode(9);
			root.GetRight.GetRight = new BinaryTreNode(12);
			root.GetLeft.GetRight.GetLeft = new BinaryTreNode(5);
			root.GetLeft.GetRight.GetRight = new BinaryTreNode(7);
			root.GetLeft.GetLeft.GetLeft = new BinaryTreNode(1);
			root.GetLeft.GetLeft.GetRight = new BinaryTreNode(3);
			root.GetRight.GetRight.GetLeft = new BinaryTreNode(11);
			root.GetRight.GetRight.GetRight = new BinaryTreNode(13);

			//Console.WriteLine(root.GetParent(root, root.GetRight.GetRight.GetRight).GetData);
							
		
		/*
						IsSubTree2 isSubtree = new IsSubTree2();
						Console.WriteLine(isSubtree.IsSubtree(root1, root2));
						// */
			#endregion

			#region IdenticalTrees
			/*
			BinaryTreNode root1 = new BinaryTreNode(6);
			root1.GetLeft = new BinaryTreNode(2);
			root1.GetRight = new BinaryTreNode(4);

			root1.GetLeft.GetLeft = new BinaryTreNode(9);
			root1.GetLeft.GetRight = new BinaryTreNode(8);
			root1.GetRight.GetLeft = new BinaryTreNode(7);
			root1.GetRight.GetRight = new BinaryTreNode(6);

			BinaryTreNode root2 = new BinaryTreNode(2);
			root2.GetLeft = new BinaryTreNode(9);
			root2.GetRight = new BinaryTreNode(8);

			BinaryTreNode bt = new BinaryTreNode();
			Console.WriteLine(bt.GetParent(root, root1.GetRight.GetRight));

			//IfTwotreesAreIdentical isIdentical = new IfTwotreesAreIdentical();
			//Console.WriteLine(isIdentical.AreIdentical(root1, root1));
			// */
			#endregion

			#region GetMaxDepthOfOddLevel
			/*
			DeepestOddLevelLeafHeight depth = new DeepestOddLevelLeafHeight();
			Console.WriteLine(depth.FindDepth(root2));
			Console.WriteLine(depth.FindDepth(root));
			// */
			#endregion

			#region InOrderSuccessor
			/*
            InOrderSuccessor ios = new InOrderSuccessor();
            Console.WriteLine(ios.GetSuccessor(root, root.GetRight.GetRight)); 
            // */
			#endregion

			#region Graph Implementation

			//GraphNode root = new GraphNode(10);
			//GraphNode[] neig1 = new GraphNode[2];
			//GraphNode[] neig2 = new GraphNode[2];
			//GraphNode[] neig3 = new GraphNode[2];
			//GraphNode[] neig4 = new GraphNode[2];
			//GraphNode[] neig5 = new GraphNode[2];


			//GraphNode n1 = new GraphNode(20);
			//GraphNode n2 = new GraphNode(30);
			//GraphNode n3 = new GraphNode(40);
			//GraphNode n4 = new GraphNode(50);
			//neig1[0] = n1;
			//neig1[1] = n2;

			//neig2[0] = root;
			//neig2[1] = n3;

			//neig3[0] = root;
			//neig3[1] = n3;

			//neig4[0] = n1;
			//neig4[1] = n2;

			//neig5[0] = n3;
			//neig5[1] = n1;

			//root.adjacents = neig1;
			//n1.adjacents = neig2;
			//n2.adjacents = neig3;
			//n3.adjacents = neig4;
			//n4.adjacents = neig5;
			#endregion

			#region IsRouteExists
			/*
             RouteBetweenTwoNodes route = new RouteBetweenTwoNodes();
             Console.WriteLine(route.IsRouteExists(n1, n3));
             // */
			#endregion

			#region BFS 
			/*
            Graph g = new Graph();
            Console.WriteLine(g.DepthFirstSearch(root, 200));
            #
            // */
			#endregion

			#region DFS
			/*
             Graph g = new Graph();
             Console.WriteLine();
             Console.WriteLine(g.BreadthFirstSearch(root, 20));
            // */
			#endregion DFS

			#region ListOfNodes at each level
			/*
            ListOfNodesAtEachLevel list = new ListOfNodesAtEachLevel();

            foreach (var d in list.GetList(root))
            {
                Console.Write("\n"+d.Key + " : ");
                foreach (var v in d.Value)
                {
                    Console.Write(v.GetData + " ");
                }
            }
            // */
			#endregion

			#region GraphImplementation 2
			/*
			Graph2<int> G = new Graph2<int>();
           GraphNode2<int> root = G.Addnode(10);
            G.AddEdge(10, 20);
            G.Addnode(30);
            G.AddEdge(10,30);
            G.Addnode(40);
            G.AddEdge(30,40);
            G.AddEdge(40,50);
            G.Addnode(20);
            G.AddEdge(50, 60);
            G.Addnode(70);

            // Console.WriteLine(G.BreadthFirstSearch(root, 30).GetData);
           // Console.WriteLine(G.DepthFirstSearch(root, 30).GetData);

            foreach (Edge<int> e in G.GetAllEdges)
            {
               // Console.Write(e.GetStart.GetData + "\t");
                //Console.WriteLine(e.GetEnd.GetData);
            }

            foreach (GraphNode2<int> n in G.GetAllNodes)
            {
               // Console.WriteLine(n.GetData);
            }

          //  G.BreadthFirstGetPath(root, G.GetNodeByData(50));
           G.DepthFirstGetPath(root, G.GetNodeByData(50));
		   // */
			#endregion
			#endregion
			#endregion Trees and Graphs

			#region Searching and Sorting
			#region GroupAnagrams
			/*
			GroupAnagrams ana = new GroupAnagrams();
			List <string> list = new List<string>();
			list.Add("shia");
			list.Add("abc");
			list.Add("saih");
			list.Add("xyz");
			list.Add("hsia");
			list.Add("cab");
			list.Add("lol");

			  ;
			foreach (string str in ana.SortGroupAnagrams(list))
			{ Console.WriteLine(str); }
			// */
			#endregion

			#region Sparce Search
			/*
			SparceSearch s = new SparceSearch();
			 Console.WriteLine(s.GetSearchIndexIterative(new string[] { "fg", "", "","abv","","","","ab",""}, "ab"));
			Console.WriteLine(s.GetSearchRecursive(new string[] { "aa", "", "", "bv", "", "", "", "cd", "" }, "aa", 0, 8));
			#endregion
			// */
			#endregion

			#region SortedSearch No size
			/*
			SortedSearch_NoSize ss = new SortedSearch_NoSize();
			int[] arr = new int[]{1,2,3,4,5,6,7,8,9,10,-1,-1,-1};
			Console.WriteLine(ss.Search(arr, 9));
			// */
			#endregion


			RankTree rank = new RankTree();
			int[] arr = new int[] { 5,1,4,4,5,9,7,13,3 };
            //Console.WriteLine(rank.Rank(arr, 4));
            //Console.WriteLine(rank.Rank(arr, 9));
            //Console.WriteLine(rank.Rank(arr, 7));
            //Console.WriteLine(rank.Rank(arr, 13));

            #region Search In Rotated Array
            /*
			SearchInRoatetdArray search = new SearchInRoatetdArray();
			Console.WriteLine(search.Search((new int[] { 5, 6, 7, 1, 2, 3, 4 }), 3, 0, 6 ));
			*/
            #endregion
            #endregion


            #region LPS
            /*
			LongestPalindromicSubstring lps = new LongestPalindromicSubstring();
			Console.WriteLine(lps.Result(""));
			Console.WriteLine(lps.Result(null));
			Console.WriteLine(lps.Result("a"));
			Console.WriteLine(lps.Result("ab"));
			Console.WriteLine(lps.Result("bab"));
			Console.WriteLine(lps.Result("lol"));
			Console.WriteLine(lps.Result("banana"));
			Console.WriteLine(lps.Result("mango"));
			Console.WriteLine(lps.Result("apple"));
			Console.WriteLine(lps.Result("abcde"));
			*/
            #endregion

            #region LCS
            /*
			LongestCommonSubstring lcs = new LongestCommonSubstring();
			List<string> res = new List<string>();

			res = lcs.Result("", null);
			res = lcs.Result("", "avh");
			//res = lcs.Result("abcdef", "defgbcdjhg");
			//res = lcs.Result("banana", "nana");
			//res = lcs.Result("ififif", "iff");
			foreach (string str in res)
			{
				Console.WriteLine(str);
			}
			*/
            #endregion

            #region LongestPalindromic Subsequence
            /*
			//TestCase: alapasl-> 5, lmaonkl-> 3 , abcgdfba-> 5, abdjkbla-> 5  
			//PassCase: "" ->"", 0-> "", fhdkfjhkdh->5
			LongestPalindrominSubsequence lps2 = new LongestPalindrominSubsequence();
			Console.WriteLine(lps2.Result(null));
			*/
            #endregion
            #region LongestCommonSubsequence
            /*
			//PassCase: { hello, helylpo}->5, { ok, okj}->2,{ por, snore}->2
			// FailCase: { "", fabcf}--> "", { jkdhjkdf, ""}-> ""
			LongestCommonSubsequence lcs2 = new LongestCommonSubsequence();
			Console.WriteLine(lcs2.Result("hello", "helylpo"));
			Console.WriteLine(lcs2.Result("ok", "okj"));
			Console.WriteLine(lcs2.Result("por", "snore"));
			Console.WriteLine(lcs2.Result("", "snore"));
			Console.WriteLine(lcs2.Result("por", null));
			Console.WriteLine(lcs2.Result("", null));
			*/
            #endregion

            #region HashMap Implementation
            /*
			HashMap hashmap = new HashMap();
			hashmap.Put(1, 2);
			hashmap.Put(9, 9);
			hashmap.Put(11, 11);
			hashmap.Put(45, 45);
			hashmap.Put(22, 22);
			hashmap.Put(33, 33);
			hashmap.Put(18, 18);
			hashmap.Put(3, 3);

			Console.WriteLine(hashmap.Get(45));
			Console.WriteLine(hashmap.Get(55));
			Console.WriteLine(hashmap.Get(33));
			Console.WriteLine(hashmap.Get(18));
			*/
            #endregion

            #region LengthOfLongestSubstring with no repeats
            //Pass case: "abcabcbb"->3
            /*
			LengthOfLongestSubstring res = new LengthOfLongestSubstring();
			Console.WriteLine(res.Result("dskjgjhabcdefghijklfhddf kjgfd"));
			*/
            #endregion

            #region ReverseString 2
            /*
			ReverseString2 str = new ReverseString2();
			Console.WriteLine(str.ReverseWords("a b c"));
			Console.WriteLine(str.ReverseWords("a b"));
			Console.WriteLine(str.ReverseWords("a"));
			Console.WriteLine(str.ReverseWords("Hello World"));
            */
            #endregion

            #region Trie Implementation
            /*
                List<string> list = new List<string>();
                list.Add("car");
                list.Add("carrom");
                list.Add("roll");
                Trie trie = new Trie(list);
                Console.Write(trie.IsContains("abs"));
            */
            #endregion

            #region LRU Implementation
            /*
            LRU lru = new LRU(3);
            lru.PutItem(0, 10);
            lru.PutItem(2, 40);
            lru.PutItem(4, 40);
            lru.PutItem(6, 60);

            Console.WriteLine(lru.GetItem(6));
            */
            #endregion

            Console.ReadLine();


		}
	}

}
