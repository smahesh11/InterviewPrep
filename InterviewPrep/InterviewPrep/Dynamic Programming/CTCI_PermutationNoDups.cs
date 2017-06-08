using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class PermutationNoDups
    {
        public List<string> FindPermutations(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new List<string>() {""};

            List<string> res = new List<string>();
            FindPermutations(str, "", res );

            return res;
        }

        public void FindPermutations(string str, string prefix, List<string> result)
        {
            if (str.Length == 0)
                result.Add(prefix);
            for (int i = 0; i < str.Length; i++)
            {
                FindPermutations(str.Substring(0,i)+str.Substring(i+1), prefix+str[i], result);
            }
        }
    }
}
