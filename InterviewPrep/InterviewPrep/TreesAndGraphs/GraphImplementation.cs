using InterviewPrep.Stacks_and_Queues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class Graph
    {
        public bool BreadthFirstSearch(GraphNode n, int data)
        {
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(n);
            n.visited = true;

            while (q.Count() > 0)
            {
                GraphNode x = q.Dequeue();
                //Console.WriteLine(x.GetData);
                if (x.GetData == data)
                    return true;
                foreach (GraphNode adj in x.adjacents)
                {
                    if (!adj.visited)
                    {
                        q.Enqueue(adj);
                        adj.visited = true;
                    }
                }
            }
            return false;
        }

        bool _found = false;
        public bool DepthFirstSearch(GraphNode root, int data)
        {
            //bool found=false;
            // Console.WriteLine(root.GetData);
              if (root.GetData == data)
            {
                _found = true;            
            }
            root.visited = true;
            GraphNode node = root;

            foreach (GraphNode adj in node.adjacents)
            {
                if (!adj.visited)
                {
                    DepthFirstSearch(adj, data);
                }
            }
            return _found; 
        }

    }
    public class GraphNode
    {
        int _data;
        public bool visited = false;
        public GraphNode[] adjacents;

        public GraphNode(int data)
        {
            _data = data;
        }

        public int GetData
        {
            get
            { return _data; }
        }

        public GraphNode[] GetNeighbors
        {
            get
            { return adjacents; }
        }
    }
}
