using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class Graph2<T>
    {
        List<GraphNode2<T>> _nodes = new List<GraphNode2<T>>();
        List<Edge<T>> _edges = new List<Edge<T>>();

        // enum State {Visited, Unvisited}

        public List<GraphNode2<T>> GetAllNodes
        {
            get { return _nodes; }
            set { _nodes = value; }
        }
        public List<Edge<T>> GetAllEdges
        {
            get { return _edges; }
            set { _edges = value; }
        }

        public GraphNode2<T> Addnode(T data)
        {
            foreach (GraphNode2<T> n in GetAllNodes)
            {
                if (n.GetData.Equals(data))
                {
                    return n;
                }
            }
            GraphNode2<T> node = new GraphNode2<T>();
            node.GetData = data;
            node.GetAdjacents = new List<GraphNode2<T>>();
            GetAllNodes.Add(node);

            return node;
        }

        public void AddEdge(T start, T end)
        {
            GraphNode2<T> startNode = null;
            GraphNode2<T> endNode = null;
            foreach (GraphNode2<T> node in GetAllNodes)
            {
                if (node.GetData.Equals(start))
                    startNode = node;

                if (node.GetData.Equals(end))
                    endNode = node;
            }

            if (startNode == null) startNode = Addnode(start);

            if (endNode == null) endNode = Addnode(end);

            //if (startNode.GetAdjacents == null)
            //    startNode.GetAdjacents = new List<GraphNode2<T>>();

            startNode.GetAdjacents.Add(endNode);
            //if not DAG:
            //endNode.GetAdjacents.Add(startNode);

            Edge<T> edge = new Edge<T>();
            edge.GetStart = startNode;
            edge.GetEnd = endNode;

            GetAllEdges.Add(edge);
        }
        
        public GraphNode2<T> GetNodeByData(T data)
        {
            foreach (GraphNode2<T> node in GetAllNodes)
            {
                if (node.GetData.Equals(data))
                    return node;
            }
            return null;
        }

        public GraphNode2<T> BreadthFirstSearch(GraphNode2<T> n, T data)
        {
            Queue<GraphNode2<T>> q = new Queue<GraphNode2<T>>();
            q.Enqueue(n);
            n.IsVisited = true;

            while (q.Count() > 0)
            {
                GraphNode2<T> x = q.Dequeue();
                //Console.WriteLine(x.GetData);
                if (x.GetData.Equals(data))
                    return x;
                foreach (GraphNode2<T> adj in x.GetAdjacents)
                {
                    if (!adj.IsVisited)
                    {
                        q.Enqueue(adj);
                        adj.IsVisited = true;
                    }
                }
            }
            return null;
        }

            public GraphNode2<T> BreadthFirstGetPath(GraphNode2<T> n1, GraphNode2<T> n2)
           {
            Queue<GraphNode2<T>> q = new Queue<GraphNode2<T>>();
            q.Enqueue(n1);
            n1.IsVisited = true;

            while (q.Count() > 0)
            {
                GraphNode2<T> x = q.Dequeue();
                Console.WriteLine(x.GetData);
                //Console.WriteLine(x.GetData);
                if (x.Equals(n2))
                    break;
                foreach (GraphNode2<T> adj in x.GetAdjacents)
                {
                    if (!adj.IsVisited)
                    {
                        q.Enqueue(adj);
                        adj.IsVisited = true;
                    }
                }
            }
            return null;
        }

        GraphNode2<T> _found = null;
        public GraphNode2<T> DepthFirstSearch(GraphNode2<T> root, T data)
        {
            //bool found=false;
            // Console.WriteLine(root.GetData);
            if (root.GetData.Equals(data))
            {
                _found = root;
            }
            root.IsVisited = true;
            GraphNode2<T> node = root;

            foreach (GraphNode2<T> adj in node.GetAdjacents)
            {
                if (!adj.IsVisited)
                {
                    DepthFirstSearch(adj, data);
                }
            }
            return _found;
        }

        public GraphNode2<T> DepthFirstGetPath(GraphNode2<T> n1, GraphNode2<T> n2)
        {
            Stack<GraphNode2<T>> q = new Stack<GraphNode2<T>>();
            q.Push(n1);
            n1.IsVisited = true;

            while (q.Count() > 0)
            {
                GraphNode2<T> x = q.Pop();

                Console.WriteLine(x.GetData);

                if (x.Equals(n2))
                    return x;
                foreach (GraphNode2<T> adj in x.GetAdjacents)
                {
                    if (!adj.IsVisited)
                    {
                        q.Push(adj);
                        adj.IsVisited = true;
                    }
                }
            }
            return null;                       
        }
    }

    public class Edge<T>
    {
        GraphNode2<T> _start;
        GraphNode2<T> _end;
        int _weight;

        public GraphNode2<T> GetStart
        {
            get { return _start; }
            set { _start = value; }
        }

        public GraphNode2<T> GetEnd
        {
            get { return _end; }
            set { _end = value; }
        }

        public int GetWeight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }

    public class GraphNode2<T>
    {
        T _data;
        List<GraphNode2<T>> _adjacents;
        bool _visited= false;

        public bool IsVisited
        {
            get { return _visited; }
            set { _visited = value; }
        }
        public T GetData
        {
            get { return _data; }
            set { _data = value; }
        }

        public List<GraphNode2<T>> GetAdjacents
        {
            get { return _adjacents; }
            set { _adjacents = value; }
        }
    }
}
