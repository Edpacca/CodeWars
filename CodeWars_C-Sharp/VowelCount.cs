using System.Collections.Generic;

// Return the number (count) of vowels in the given string.
// We will consider a, e, i, o, u as vowels for this Kata (but not y).
// The input string will only consist of lower case letters and/or spaces.

namespace CodeWars
{
    class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

            foreach (var letter in str)
                if (vowels.Contains(letter))
                    vowelCount++;

            return vowelCount;
        }
    }
}
