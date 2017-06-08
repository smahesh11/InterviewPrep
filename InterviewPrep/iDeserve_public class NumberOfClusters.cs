using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class NumberOfClusters
    {
        readonly static int[] offsets = { -1, 0, +1 };

        private bool IsOne(int[,] matrix, int i, int j)
        {
            if ((i >= 0) && (i < matrix.Length) && (j >= 0) && (j < 6))
            {
                if (matrix[i, j] == 1)
                {
                    return true;
                }
            }

            return false;
        }

        private void doDFS(int[,] matrix, int i, int j, bool[,] visited)
        {
            if (visited[i, j])
            {
                return;
            }

            // mark this vertex as visited and visit all its neighbors in depth first manner
            visited[i, j] = true;

            int xOffset, yOffset;
            for (int l = 0; l < offsets.Length; l++)
            {
                xOffset = offsets[l];
                for (int m = 0; m < offsets.Length; m++)
                {
                    yOffset = offsets[m];

                    // do not consider vertex[i,j] as its own neighbor
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }

                    // check if there exists a vertex at this offset and check if it is '1'
                    if (IsOne(matrix, i + xOffset, j + yOffset))
                    {
                        doDFS(matrix, i + xOffset, j + yOffset, visited);
                    }
                }
            }
        }


        public int findNumberofClusters(int[,] matrix)
        {
            // JVM initializes all values to false by default.
            bool[,] visited = new bool[matrix.Length, 6];

            int count = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if ((matrix[i, j] == 1) && (!visited[i, j]))
                    {
                        // vertex [i,j] marks start of new a cluster. DFS then visits all vertices of this cluster
                        count += 1;
                        doDFS(matrix, i, j, visited);
                    }
                }
            }
            return count;
        }

    }
}
