using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
    public class CTCIPalindromePermutation
    {
        public static bool IsPalindromePermutation(string str)
        {
            //Time Complexity : O(n^2)
            //Space Complexity : O(n)
            if (string.IsNullOrEmpty(str))
                return false;
			
            Dictionary<char, int> freq = new Dictionary<char, int>();

           
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    continue;
                
                 int count = 0;

                if (freq.ContainsKey(str[i]))
                {
                    freq.TryGetValue(str[i], out count);
                    freq[str[i]] = ++count;
                }
               else freq.Add(str[i], ++count);
            }

            int notUnique = 0;
            foreach (var item in freq)
            {
                int count = 0;
                freq.TryGetValue(item.Key, out count);
                if (count % 2 != 0)
                    notUnique++;
            }

            if (notUnique > 1)
                return false;

            else return true;

            ////int strlen = 0;
            ////for (int i= 0;i< str.Length;i++)
            ////{
            ////    if(str[i]!=' ')
            ////    strlen++;
            ////}

            ////int notUnique = strlen / 2;
            //int count = 0;
            //int uniquecount = 0;
            //for (int i = 0;i < str.Length-1;i++)
            //{
            //    if (str[i] == ' ')
            //        continue;

            //    string subSubstring = str.Substring(i+1);
            //    if (subSubstring.Contains(str[i]))
            //        count += 2;
            //    else
            //    {
            //        count++;
            //        uniquecount++;
            //    }
            //}                   

            //if (count % 100 == 0 || uniquecount<=1)
            //    return true;


            //return false; 


            //First check if the letters can form palindrome
            // generate permutations
            //Reverse each permutation and see if original and reversed strings are same
            //if yes add to list
            //return list

           // return new List<string>();
        }
    }
}
