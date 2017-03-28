using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
    public class CTCIIsRotation
    {
        private bool isSubstring(string sub, string main)
        {      
            if (main.Contains(sub)) //O(n)
                return true;

            return false;
        }

        public bool isRotation(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
                return false;

            if (isSubstring(s1, s1+s2))//O(n)
                return true;

            return false;
        }
    }
}
