using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Sorting_and_Searching
{
	public class GroupAnagrams
	{
		//TimeComplexity: O(n^2)
		public List<string> SortGroupAnagrams(List<string> list)
		{
			Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();
			

			foreach (string str in list)
			{
				string key = sortString(str);

				List<string> valList = new List<string>();
				if (anagrams.ContainsKey(key))
				{
					anagrams.TryGetValue(key, out valList);
				}

				valList.Add(str);
				anagrams[key] = valList;

			}

			List<string> sorted = new List<string>();

			foreach (string key in anagrams.Keys)
			{				
				foreach (string val in anagrams[key])
				{
					sorted.Add(val);
				}
			}
			return sorted;
		}

		public string sortString(string str)
		{
			char[] arr = str.ToCharArray();
			Array.Sort(arr);

			return new string(arr);
		}
	}
}
