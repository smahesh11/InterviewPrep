using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
	public class LongestCommonSubstring
	{
		/*
		 Pass Case: {a, a}-> a, {a, ab}-> a, {abcde, bcd}->bcd
		 Fail Case:  {a, b}-> "", {khd, fat}-> ""
		 Hack Case: {"wl;jkqehuioty2hx9872/.......", "dekjagf7edbneju..."}
		 * */
		public List<string> Result(string str1, string str2)
		{
			List<string> list = null;

			if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
				return list;

			int n1 = str1.Length;
			int n2 = str2.Length;
			int max = Int32.MinValue;
			
			int[,] mat = new int[n1, n2];
			for (int i = 0; i < n1; i++)
			{
				for (int j = 0; j < n2; j++)
				{
					if (str1[i] == str2[j])
					{
						if (i == 0 || j == 0)
							mat[i, j] = 1;

						else mat[i, j] = mat[i - 1, j - 1] + 1;


						if (mat[i, j] > max)
						{
							max = mat[i, j];
							list = new List<string>();
							list.Add(str1.Substring(i - max + 1, max));
						}
						else if (max == mat[i, j])
						{
							list.Add(str1.Substring(i - max + 1, max ));
						}
					}
					else mat[i, j] = 0;
				}
				
			}


			return list;
		}
	}
}
