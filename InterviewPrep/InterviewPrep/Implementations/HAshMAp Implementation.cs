using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Implementations
{
	public class Node
	{
		public int key;
		public int val;
		public Node next;

		public Node(int k, int v)
		{
			key = k;
			val = v;
		}
	}
	public class HashMap
	{
		List<Node> list = new List<Node>();
		Node node =null;

		public HashMap()
		{
			for (int i = 0; i <= 15; i++)
			{
				list.Add(null);
			}
		}
		int GetHash(int key)
		{
			return (key % 15);
		}

		

		public void Put(int key, int value)
		{
			int hash = GetHash(key);
			if (list[hash] == null)
			{
				node = new Node(key, value);
				list[hash] = node;
			}
			else
			{
				node = list[hash];
				Node head = node;
				while (node != null)
				{
					node = node.next;
				}
				node = new Node(key, value);
				list[hash] = head;
			}
			
		}

		public void Remove(int key)
		{
			int hash = GetHash(key);
			if (list[hash] != null)
			{
				node = list[hash];					

				while (node.next != null)
				{
					if (node.key == key)
						node = node.next;
				}
				list[hash] = node;
			}
		}

		public int Get(int key)
		{
			int hash = GetHash(key);
			node = list[hash];
			Node head = node;

			while (node != null)
			{
				if (node.val == key)
				{
					return node.val;
				}
				node = node.next;
			}
			list[hash] = head;
			return -1; 
		}
	}
}
