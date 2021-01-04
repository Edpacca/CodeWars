using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// By the way you don't have to check errors or incorrect input values, everything is ok without bad tricks, only two input strings and as result one output string;-)...
// Input Strings a and b: For every character in string a swap the casing of every occurrence of the same character in string b. 
// Then do the same casing swap with the inputs reversed. 
// Return a single string consisting of the changed version of a followed by the changed version of b. 
// A char of a is in b regardless if it's in upper or lower case - see the testcases too.

namespace CodeWars
{
    class PlayWithTwoStrings
    {
        public static string workOnStrings(string a, string b)
        {
            var dictA = DictMaker(a);
            var dictB = DictMaker(b);

            return (caseFlip(a, dictB) + caseFlip(b, dictA));
        }

        public static Dictionary<char, int> DictMaker(string str)
        {
            var dict = new Dictionary<char, int>();

            foreach (char character in str)
                if (!dict.ContainsKey(Char.ToLower(character)))
                    dict.Add(Char.ToLower(character), str.Count(x => (Char.ToLower(x) == Char.ToLower(character))));

            return dict;
        }

        public static string caseFlip(string str, Dictionary<char, int> dict)
        {
            var result1 = new StringBuilder();

            foreach (char character in str)
                if (dict.ContainsKey(Char.ToLower(character)))
                {
                    if (dict[Char.ToLower(character)] % 2 == 0)
                        result1.Append(character);
                    else
                    {
                        if (Char.IsUpper(character))
                            result1.Append(Char.ToLower(character));
                        else
                            result1.Append(Char.ToUpper(character));
                    }
                }
                else
                    result1.Append(character);

            return result1.ToString();
        }
    }
}
