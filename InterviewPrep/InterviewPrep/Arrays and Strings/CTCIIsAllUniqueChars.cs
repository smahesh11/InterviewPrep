using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
  public class CTCIIsAllUniqueChars
    {
        public bool IsUnique_One(string str)
        {
            //Space Complexity: O(1)
            //Time Complexity: O(n)
            if (string.IsNullOrEmpty(str))
                return false;

            int[] charArray = new int [256];
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (charArray[ch] == 1)
                    return false;

                else charArray[ch] = 1;                   
            }           

            return true;
        }

        public bool IsUnique_Two(string str)
        {
            //Space Complexity: O(1)
            //Time Complexity : O(n^2)
            if (string.IsNullOrEmpty(str))
                return false;

           
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {                    
                    if (str[i] == str[j])
                        return false;                }
            }

            return true;
        }
    }
}
