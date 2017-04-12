using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
namespace InterviewPrep.Arrays_and_Strings
{
    public class CTCICheckPermutation
    {
        /// <summary>
        /// Method to sort a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns> Soeted string</returns>
        private string sort(string str)
        {
            //TODO: Implement string sorting
            return null;
        }

        /// <summary>
        /// Sort both strings and check if the sorted strings are equal
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>True or False</returns>
        public bool isPermutation(string str1, string str2)
        {
            //Complexity :O(n log n)
            if (str1.Length != str2.Length)
                return false;
            if (String.IsNullOrEmpty(str1))
                return false;
            
            str1 = str1.ToUpper();
            str2 = str2.ToUpper();

            char[] str1Arr = str1.ToCharArray();// O(n)
            char[] str2Arr = str2.ToCharArray();// O(n)


            Array.Sort(str1Arr); //O(n logn)
            Array.Sort(str2Arr); //O(n logn)

            if (Enumerable.SequenceEqual(str1Arr, str2Arr)) //O(n)
                return true;

            return false;
        }
    }
}
