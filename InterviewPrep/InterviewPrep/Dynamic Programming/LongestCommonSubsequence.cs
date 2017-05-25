using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
	public class LongestCommonSubsequence
	{
		/*
			 PassCase: {hello, helylpo}->5, {ok, okj}->2,{por, snore}->2
			 FailCase:{"", fabcf}--> "", {jkdhjkdf, ""}-> ""
			 HackCase: {null, ""}, {null, null}, {wgedjgdgdjhy....., 9679weve5%65....}
		*/
		public string Result(string str1, string str2)
		{
			if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
				return "";			
			
			int len1 = str1.Length;
			int len2 = str2.Length;

			int[,] mat = new int[len1, len2];
			int[,] pointer = new int[len1, len2];

			int p1 = 0, p2=1, p1_p2 = 2;

			for (int i = 0; i < len1; i++)
			{
				for (int j = 0; j < len2; j++)
				{
					if (str1[i] == str2[j])
					{
						if (i == 0 || j == 0)
						{
							mat[i, j] = 1;
						}

						else
						{
							mat[i, j] = mat[i - 1, j - 1] + 1;
							pointer[i, j] = p1_p2;
						}
					}

					else
					{
						if (i > 0 && j > 0)
						{
							if (mat[i, j - 1] > mat[i - 1, j])
							{
								mat[i, j] = mat[i, j - 1];
								pointer[i, j] = p1;
							}

							else
							{
								mat[i, j] = mat[i - 1, j];
								pointer[i, j] = p2;
							}
						}
						if (i == 0 && j > 0)
						{
							mat[i, j] = mat[i, j - 1];
							pointer[i, j] = p1;
						}

						else if (i > 0 && j == 0)
						{
							mat[i, j] = mat[i -1, j];
							pointer[i, j] = p2;
						}
					}
				}				
			}

			int k = len1 - 1, l = len2 - 1;
			StringBuilder str = new StringBuilder();

			while (k >= 0 && l >= 0)
			{
				if (pointer[k, l] == 2)
				{
					str.Append(str1[k]);
					k--;
					l--;
				}

				else if (pointer[k, l] == 1)
					k--;

				if (pointer[k, l] == 0)
					l--; ;
				
			}
			return str.ToString();
		}
	}
}
