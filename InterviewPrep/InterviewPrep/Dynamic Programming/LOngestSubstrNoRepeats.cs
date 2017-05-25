using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
	public class LengthOfLongestSubstring
	{
		public int Result(String s)
		{

			if (string.IsNullOrEmpty(s))
				return 0;

			int[] last = new int[256];

			for (int i = 0; i < last.Length; i++)
			{
				last[i] = -1;
			}

			last[s[0]] = 0;
			int max = 1;
			int curr = 1;
			int start = 0;

			for (int i = 1; i < s.Length; i++)
			{
				if (last[s[i]] == -1)
				{
					last[s[i]] = i;
					curr++;
				}

				else
				{
					start = last[s[i]] + 1;
					curr = i - last[s[i]];
					last[s[i]] = i;
				}
				if (curr > max)
					max = curr;
			}

			return max;
		}
	}
}
