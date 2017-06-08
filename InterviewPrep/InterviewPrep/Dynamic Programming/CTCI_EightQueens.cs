using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class EightQueens
    {
        readonly int GridSize = 8;
        public void PlaceQueens(int row, int[] columns, List<int[]> ways)
        {
            if (row == GridSize)
                ways.Add(columns);
            else
            {
                for (int col = 0; col < GridSize; col++)
                {
                    if (IsValid(columns, row, col))
                    {
                        columns[row] = col;
                        PlaceQueens(row + 1, columns, ways);
                    }
                }
            }
        }

        public bool IsValid(int[] columns, int row, int col)
        {
            for (int row2 = 0; row2 < row; row2++)
            {
                int col2 = columns[row2];

                if (col == col2)
                    return false;

                if (Math.Abs(col2 - col) == Math.Abs(row2 - row))
                    return false;
            }
            return true;
        }
    }
}
