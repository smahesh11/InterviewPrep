using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class PermutationWithDups
    {
        public List<string> GetPermutations(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new List<string>() {""};

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char ch in str)
            {
                if (!dict.ContainsKey(ch))
                    dict.Add(ch, 1);
                else
                    dict[ch] = dict[ch]++;
            }

            List<string> result = new List<string>();
            GetPermutations("", str.Length-1, result, dict);

            return result;
        }
        
        public void GetPermutations( string prefix, int len, List<string> result, Dictionary<char, int> map)
        {
            if (len == 0)
            {
                result.Add(prefix);
                return;
            }

            foreach (char ch in map.Keys)
            {
                int count = map[ch];
                if (count > 0)
                {
                    map.Remove(ch);
                    map.Add(ch, count - 1);
                    GetPermutations(prefix + count, len - 1, result, map);
                    map.Remove(ch);
                   map.Add(ch, count);
                }
            }
        }
    }
}
