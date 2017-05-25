using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
	public class LongestPalindrominSubsequence
	{
		/*
		 TestCase: alapasl-> laal, lmaonkl-> ll , abcgdfba-> abba, abdjkbla-> abba  
		PassCase: "" ->"",fhdkfjhkdh->hkkh
		HackCase : null, "798736vdsy359798^*&@%&@................"
		*/
		public int Result(string str)
		{
			if (String.IsNullOrEmpty(str))
				return 0;
			int len = str.Length;
			int[,] mat = new int[len, len];

			//for subsequence of length 1; ---diagonal of matrix
			for (int i=0;i<len;i++)
			{
				mat[i,i] = 1;
			}

			for (int curr_len = 2; curr_len <= len; curr_len++)
			{
				for (int i = 0; i < len - curr_len + 1; i++)
				{
					int j = i + curr_len - 1;

					if (str[i] == str[j])
						mat[i, j] = mat[i + 1, j - 1] + 2;

					else mat[i, j] = Math.Max(mat[i,j-1], mat[i+1,j]);
				}

			}
			return mat[0, len - 1];
		}
	}
}
