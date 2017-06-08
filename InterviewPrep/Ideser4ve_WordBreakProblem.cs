using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{

        public class WordBreak
        {
	
	    private static  List<String> dictionary = new List<String>() { "arrays", "dynamic", "heaps", "IDeserve", "learn", "learning", "linked", "list", "platform", "programming", "stacks", "trees" };

          public static bool hasValidWords(String words)
            {               
             if (words == null || words.Length == 0)
                {
                                  return true;
                              }
                         int n = words.Length;
                         bool[] validWords = new bool[n];
                         for (int i = 0; i < n; i++)
                         {
                                  if (dictionary.Contains(words.Substring(0, i + 1)))
                                    {
                                          validWords[i] = true;
                                     }
                                 if (validWords[i] == true && (i == n - 1))
                                         return true;
                                 if (validWords[i] == true)
                                        {
                                       for (int j = i + 1; j < n; j++)
                                         {
                                                 if (dictionary.Contains(words.Substring(i + 1, n-1-i-1+j-1)))
                                        {
                                                validWords[j] = true;
                                        }                      if (j == n - 1 && validWords[j] == true)
                                        {
                                                                      return true;
                                                                  }
                                          }
                                       }
                         }

            foreach (bool s in validWords)
            {
                Console.WriteLine(s);

            }
                         return false;
                   }
	
	    public static void main(String[] args)
            {
                         if (hasValidWords("IDeservelearningplatform"))
                               Console.WriteLine("true");
                          else
             Console.WriteLine("false");
                     }
	}
    }

