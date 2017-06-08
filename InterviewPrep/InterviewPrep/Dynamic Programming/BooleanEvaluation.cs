using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class BooleanEvaluation
    {
        public int Count(string str, bool result, Dictionary<string, int> dict)
        {
            if (str.Length == 0)
                return 0;
            if (str.Length == 1)
                return (result ? 1 : 0);

            if (dict.ContainsKey(str + result))
                return dict[str+result];

            int ways = 0;

            for (int i = 0; i < str.Length; i++)
            {
                string left = str.Substring(0, i);
                string right = str.Substring(i + 1, str.Length - 1);

                int leftTrue = Count(left, true, dict);
                int rightTrue = Count(right, true, dict);
                int leftFalse = Count(left, false, dict);
                int rightFalse = Count(right, false, dict);

                int total = leftTrue + rightTrue + leftFalse + rightFalse;

                int totalTrue = 0;

                if (i == '^')
                    totalTrue = leftTrue * rightFalse + rightTrue * leftFalse;
                if (i == '&')
                    totalTrue = leftTrue * rightTrue;
                if (i == '|')
                    totalTrue = leftTrue + rightTrue + leftTrue*rightFalse +leftFalse*rightTrue;

                int totalFalse = total = totalTrue;

                int subways = result ? totalTrue : totalFalse;
                ways += subways;
            }

            dict.Add(str+result, ways);

            return ways;
        }
    }
}
