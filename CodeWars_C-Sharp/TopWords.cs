using System.Collections.Generic;
using System;
using System.Linq;

namespace CodeWars
{
    public class TopWords
    {
        static List<char> punctuationSymbols = new List<char>() { '/', '"', '.', ':', ';', ',', '-', '?', '!', '_' };

        public static List<string> Top3(string s)
        {
            var words = ReplacePunctuation(s).ToLower().Split(' ');
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (ValidateWord(word))
                {
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else if (!string.IsNullOrEmpty(word))
                        wordCount.Add(word, 1);
                }
            }

            int amount = wordCount.Count < 3 ? wordCount.Count : 3;
            List<string> top3Words = wordCount.OrderByDescending(w => w.Value).Take(amount).Select(w => w.Key).ToList();

            return top3Words;
        }

        public static bool ValidateWord(string word)
        {
            return !word.StartsWith('\'');
        }

        public static string ReplacePunctuation(string word)
        {
            string newWord = word;

            foreach (var punctuation in punctuationSymbols)
                newWord = newWord.Replace(punctuation, ' ');

            return newWord;
        }
    }
}
