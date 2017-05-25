using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
	public class LongestPalindromicSubstring
	{
		/*PassCase: a -->a , aa-->aa, aba -->aba, banana-anana, apple->pp
		  Fail Case: ab, kbcde->k, andgaj->a
		  Hack case: null-> "", ""-> "',  %@*!^(@&!)&)->%s
	*/
		public string Result(string str)
		{

			//check for null or empty string input
			if (String.IsNullOrEmpty(str))
				return "";

			int len = str.Length;
			int start = 0;
			int max_len = 1;
			bool[,] mat = new bool[len,len];


			//if inout is single character
			for (int i = 0; i < len; i++)
			{
				mat[i,i] = true;
			}

			//check for 2 character palidromes
			for (int i = 0; i < len - 1; i++)
			{
				if (str[i] == str[i + 1])
				{
					mat[i, i + i] = true;
					start = i;
					max_len = 2;
				}
			}

			//check for string of length 3 or more

			for (int currlen = 3; currlen <= len; currlen++)
			{
				for (int i = 0; i < len - currlen + 1; i++)
				{
					int j = i + currlen - 1;

					if (str[i] == str[j] && mat[i + 1, j - 1])
					{
						mat[i, j] = true;
						start = i;
						max_len = currlen;
					}
				}
			}



			return str.Substring(start, max_len);

		}
	}
}
