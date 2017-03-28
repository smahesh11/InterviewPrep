using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
    public class CTCICharacterCount_a2b3
    {
        public static string GenerateNewString(string str)       
          {
            //Time Complexity: O(n)
            //Space Complexity: O(n)

            if (string.IsNullOrEmpty(str))
            { return ""; }

            StringBuilder newstring = new StringBuilder();
            char previous = str[0];
            int count = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == previous)
                    count++;
                else
                {
                    Console.Write(previous+count.ToString());
                    previous = str[i];
                    count = 1;
                }
            }
             newstring.Append(previous);
             newstring.Append(count.ToString());
           // Console.WriteLine (previous+count.ToString());
            return newstring.ToString();
        }
    }
}
