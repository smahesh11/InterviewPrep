using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
    public class CTCIURLify
    {
        public static string stringUrlify(string str, int size)
        {
            //Time Complexity= O(n)
            //Space Complexity = O(1)

            if (string.IsNullOrEmpty(str))
                return "";
            int n = str.Length;
            //calculate size of new string  
            int spaceCount = 0;
            for (int i = 0; i < size; i++)
            { 
                //O(n)
                if(str[i]==' ')
                spaceCount++;
            }
            int newlen = size + 2 * spaceCount;
            //char[] strArray = new char[newlen];

            char[] strArray = str.ToCharArray();
            for (int i = size-1; i>-1; i--)
            {
                if (str[i] == ' ')
                {
                    strArray[newlen - 1] = '0';
                    strArray[newlen - 2] = '2';
                    strArray[newlen - 3] = '%';
                    newlen = newlen - 3;
                }

                else
                {
                    strArray[newlen - 1] = str[i];
                    newlen--;
                }
            }

            return new string(strArray);
        }
            
    }
}
