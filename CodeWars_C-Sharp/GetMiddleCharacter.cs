using System;

// You are going to be given a word. Your job is to return the middle character of the word. 
// If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

namespace CodeWars
{
    class GetMiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            return (s.Length % 2 == 0) ? String.Concat(s[s.Length / 2 - 1], s[s.Length / 2]) : s[s.Length / 2].ToString();
        }
    }
}
