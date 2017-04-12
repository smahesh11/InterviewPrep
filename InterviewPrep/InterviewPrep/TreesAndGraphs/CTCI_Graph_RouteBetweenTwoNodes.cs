using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
   public class RouteBetweenTwoNodes
    {
        public bool IsRouteExists(GraphNode start, GraphNode end)
        {
            Queue<GraphNode> q = new Queue<GraphNode>();
            q.Enqueue(start);
            start.visited = true;

            while (q.Count != 0)
            {
                GraphNode x = q.Dequeue();
                foreach (GraphNode adj in x.adjacents)
                {
                    if (!adj.visited)
                    {
                        if (adj == end)
                            return true;
                        else
                        {
                            q.Enqueue(adj);
                            adj.visited = true;
                        }
                    }
                    
                }     
            }
           return false;
        }
    }
}
