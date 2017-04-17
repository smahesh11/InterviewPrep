using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class TopologicalSort<T>
    {
        Queue<GraphNode2<int>> _Q = new Queue<GraphNode2<int>>();
        public List<GraphNode2<int>> TopoSort(List<GraphNode2<int>> nodes, List<Edge<int>> edges)
        {
            List<GraphNode2<int>> sequence = new List<GraphNode2<int>>();
            List<GraphNode2<int>> edgeEnds = new List<GraphNode2<int>>();

            foreach (Edge<int> edge in edges)
            {
                edgeEnds.Add(edge.GetEnd);
            }

            foreach (GraphNode2<int> node in nodes)
            {
                if (!edgeEnds.Contains(node))
                {
                    _Q.Enqueue(node);
                    node.IsVisited = true;
                }
            }

            GraphNode2<int> x;

            while (_Q.Count() > 0)
            {               
               sequence.Add(x = _Q.Dequeue());
              //  Console.WriteLine((x = _Q.Dequeue()).GetData);         //uncomment for output           

                foreach (GraphNode2<int> adj in x.GetAdjacents)
                {
                    if (adj.IsVisited) continue;

                    _Q.Enqueue(adj);
                    adj.IsVisited = true;
                }
            }
            return sequence;   
        }
    }
}

