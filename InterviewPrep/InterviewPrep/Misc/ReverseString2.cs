using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Misc
{
	public class ReverseString2
	{
		public string ReverseWords(string s)
		{
			if (string.IsNullOrEmpty(s))
				return "";

			Stack<string> S2 = Buff(s);
			StringBuilder build = new StringBuilder();

			while (S2.Count != 0)
			{
				build.Append(S2.Pop());
				if(S2.Count >= 1)
				build.Append(" ");
			}			

			return build.ToString(); 
		}

		public Stack<string> Buff(string str)
		{
			int start = 0; int end = 0;
			
			Stack<string> S1 = new Stack<string>();

			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == ' ')
				{
					S1.Push(str.Substring(start, end - start ));
					start = i + 1;
				}
				end++;
			}
			S1.Push(str.Substring(start, end - start));
			return S1;

		}
	}
}
