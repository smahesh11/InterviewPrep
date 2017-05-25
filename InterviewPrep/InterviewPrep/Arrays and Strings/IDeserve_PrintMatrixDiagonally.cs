using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
	public class PrintMatrixDiagonally
	{
		public void Print(int[][] mat)
		{
			int i, j;

			for (int k =0; k< mat.Length;k++ )
			{
				for ( i = k, j = 0;  i >= 0 && j < mat[0].Length ;  i--, j++ )
				{
					Console.WriteLine(mat[i][j]);
				}
			}	

			for (int k=1; k<mat[0].Length;k++)
			{
				for ( i = mat.Length-1, j = k; i >= 0 && j < mat[0].Length ;  i--, j++)
				{
					Console.WriteLine(mat[i][j]);
					//i--; j++;
				}
			}
		}

	}
}
