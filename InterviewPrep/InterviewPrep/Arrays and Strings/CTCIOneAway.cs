using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
   public class CTCIOneAway
    {
        public static bool isOneAway(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                return false;

            if (Math.Abs(a.Length - b.Length) > 1)
                return false;

            int i = 0; int j = 0;
            int count = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a.Length == b.Length)
                {
                    if (a[i] != b[j])
                    {
                        count++;
                    }
                    i++;
                    j++;
                }
                else if (a[i] != b[j])
                {
                    if (a.Length > b.Length) i++;
                    else if (a.Length > b.Length) j++;
                    count++;
                }
                else
                //{ i++; j++; }

                if (count > 1)
                    return false;               
            }
               
                return true; 
        }
    }
}
