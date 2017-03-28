using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Arrays_and_Strings
{
    class Arrays_Strings_MainClass
    {
        static void Main(string[] args)
        {
            #region Ispermutation
            /*
             // Check if on estring is permutation of the other
             CTCICheckPermutation obj = new CTCICheckPermutation();
             Console.WriteLine(obj.isPermutation("-654@", "@-645"));

             //Console.ReadLine();
             //Pass cases: "Hello" "lohle" , "1234" "4213" , "-654@" "7-46@5", "", "" 
             //Fail cases: "Hello""Hell", "4213" "-654@", 
             //Hck cases: "Hello" "null"
             // "Hello" "lohle" "Hell" "1234" "4213" "-654@" "7-46@5" "Rev"

             //Console.WriteLine(obj.isPermutation("Hello", "Heoll")); // F
             //Console.WriteLine(obj.isPermutation("Hello", "lohle")); // T
             //Console.WriteLine(obj.isPermutation("1234", "4213")); // T
             //Console.WriteLine(obj.isPermutation("-654@", "7-46@5")); // F
             //Console.WriteLine(obj.isPermutation("Hello", "")); //F
             //Console.WriteLine(obj.isPermutation("Hello", null)); // F
             //Console.WriteLine(obj.isPermutation(null, ""));  // F
             //Console.WriteLine(obj.isPermutation("", "")); //F
             //Console.WriteLine(obj.isPermutation(null, null)); //F
           // */

            #endregion


            #region IsUniqueChars    
            /*
              // Check if a string contains all unique characters
             CTCIIsAllUniqueChars obj = new CTCIIsAllUniqueChars();
             Console.WriteLine(obj.IsUnique_One("Hello"));
             Console.WriteLine(obj.IsUnique_Two("Shweta"));
             //Console.WriteLine(obj.IsUnique_One(""));
             //Console.WriteLine(obj.IsUnique_Two(null));

             //Pass Case: "Shweta" , "water dump"
             //Fail Case: "Hello", "waterbottle"
             //Hack Case: "" , null
             */
            #endregion


            #region isRotationString

            /*
              //Check if one string is rotation of other
             CTCIIsRotation isrotaion = new CTCIIsRotation();
             Console.WriteLine(isrotaion.isRotation("12345","52143"));

             //Pass Case: "waterbottle" "erbottlewat" , "aaaaa" "aaaaa", "aaaa" "bbbb"
             //Fail Case: "Hello"  "waterbottle", "" "abc"
             //Hack Case: "" , null
             // */
            #endregion

            #region URLify
            /*
              //Check if one string is rotation of other
             Console.WriteLine(URLify.stringUrlify("Mr John Smith    ", 13));
             Console.WriteLine(URLify.stringUrlify("", 0));

             //Pass Case: "Mr John Smith    " , "   "
             //Fail Case: "Mr John Smith"  "", "" "abc"
             //Hack Case: "" , null
             string str = "";
             Console.WriteLine(str.Length);
             */
            #endregion


            #region MatrixZeroing
            /*  int[][] mat = new int[4][]
              {
                  new int[] { 1, 6, 3, 4 },
                  new int[] { 6, 7, 5, 2 },
                  new int[] { 0, 3, 2, 8 }, 
                  new int[] { 9, 7, 6, 5 } };
            //  MatrixRowsandColumnsZeroed.MatrixNullify1(mat);
              CTCIMatrixRowsandColumnsZeroed.MatrixNullify2(mat);

              //Pass case : {{ 1, 6, 3}, { 6, 7, 5}, { 0, 3, 2}}
              //Fail case: null, {{ 1, 6, 3}, { 6, }, { 0, 2}}
              //Hack Case: null
              //*/
            #endregion

            #region charactercount
            /*
           Console.WriteLine(CTCICharacterCount_a2b3.GenerateNewString("aabbbcdddd"));
           Console.WriteLine(CTCICharacterCount_a2b3.GenerateNewString("shweta"));
           Console.WriteLine(CTCICharacterCount_a2b3.GenerateNewString(null));
           Console.WriteLine(CTCICharacterCount_a2b3.GenerateNewString(""));

           //Pass case : "aabbbcdddd"- a2b3c1d4,  "shweta- s1h1w1e1t1a1"
           //Fail case: null, ""}
           //Hack Case: null
           // */
            #endregion

            #region IsOneAway
            /*
            Console.WriteLine(CTCIOneAway.isOneAway("abcd", "abcd"));// Pass
            Console.WriteLine(CTCIOneAway.isOneAway("shweta", "shwet")); // Pass
            Console.WriteLine(CTCIOneAway.isOneAway("helo", "hello")); // Pass
            Console.WriteLine(CTCIOneAway.isOneAway("hale", "pale")); // Pass
            Console.WriteLine(CTCIOneAway.isOneAway("hale", "bake")); //Fail
            Console.WriteLine(CTCIOneAway.isOneAway("", null)); //Fail
            Console.WriteLine(CTCIOneAway.isOneAway("", "a")); //Fail

            //Pass case : {"abcd", "abcd"}, { "shweta", "shwet"}, {"helo", "hello"}, {"hale", "pale"}
            //Fail case: {null, "" } ,{ "hale", "bake"}, {null, null}, {"",""}
            //Hack Case: null
            // */
            #endregion

            #region IsPalindromePermutation

            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("tact coa"));// Fail
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("abcbac"));// Pass
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("bgf gkl flbk"));// Pass
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("bgf shjsg"));// Fail
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("tact cota"));// Fail
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation("saddas assddasa"));// Fail
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation(""));// Hack
            Console.WriteLine(CTCIPalindromePermutation.isPalindromePermutation(null));// Hack


            //Pass case : {"abcd", "abcd"}, { "shweta", "shwet"}, {"helo", "hello"}, {"hale", "pale"}
            //Fail case: {null, "" } ,{ "hale", "bake"}, {null, null}, {"",""}
            //Hack Case: null
            // */
            #endregion
            Console.ReadLine();
        }

    }
}

