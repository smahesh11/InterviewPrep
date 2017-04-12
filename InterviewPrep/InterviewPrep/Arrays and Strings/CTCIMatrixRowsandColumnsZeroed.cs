using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
    public class CTCIMatrixRowsandColumnsZeroed
    {
        //private static void ZeroOutRowsandcolumns(int[][] matrix, int row, int column)
        //{
        //    int[][] newMat = new int[4][];
        //    newMat = matrix;
        //    for (int i = 0; i < matrix.Length; i++)
        //    {
        //        newMat[i][column] = 0;
        //    }

        //    for (int j = 0; j < matrix[0].Length; j++)
        //    {
        //        newMat[row][j] = 0;
        //    }
        //}

        //public static void MatrixNullify(int[][] matrix)
        //{
        //    for (int i = 0; i < matrix.Length; i++)
        //    {
        //        for (int j = 0; j < matrix[0].Length; j++)
        //        {
        //            if (matrix[i][j] == 0)
        //                ZeroOutRowsandcolumns(matrix, i, j);
        //        }
        //    }

        //    for (int i = 0; i < matrix.Length; i++)
        //    {
        //        for (int j = 0; j < matrix[0].Length; j++)
        //        {
        //            Console.Write(matrix[i][j]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        public static void MatrixNullify1(int[][] matrix)
        {

            if (matrix == null)
                return;
            //Space Complexity: O(n+m)--> O(n)
            //Time Complexity: O(nm)--> O(n^2)

            //List<int> rows = new List<int>();
            //List<int> columns = new List<int>();

            int[] rows = new int[matrix.Length];
            int[] columns = new int[matrix[0].Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows[i] = 1;
                        columns[j] = 1;
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (rows[i] == 1 || columns[j] == 1)
                        matrix[i][j] = 0;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static void MatrixNullify2(int[][] matrix)
        {
            //Space Complexity: O(1)
            //Time Complexity: O(nm)--> O(n^2)

            bool rowZero = false;
            bool columnZero = false;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[i][0] = 0;
                        matrix[0][j] = 0;

                        if (i == 0)
                            rowZero = true;
                        if (j == 0)
                            columnZero = true;
                    }
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                        matrix[i][j] = 0;
                    else matrix[i][j] = matrix[i][j];
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (columnZero)
                    matrix[i][0] = 0;
                else matrix[i][0] = matrix[i][0];
            }
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (rowZero)
                    matrix[0][j] = 0;
                else matrix[0][j] = matrix[0][j];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}

        

