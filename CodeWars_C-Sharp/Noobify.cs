using System.Collections.Generic;

// Terrible Kata.
// https://www.codewars.com/kata/552ec968fcd1975e8100005a

namespace CodeWars
{
    class Noobify
    {
        public static Dictionary<string, string> NoobDict = new Dictionary<string, string>
        {
            ["too"] = "2",
            ["to"] = "2",
            ["oo"] = "00",
            ["oO"] = "00",
            ["be"] = "b",
            ["are"] = "r",
            ["you"] = "u",
            ["please"] = "plz",
            ["people"] = "ppl",
            ["really"] = "rly",
            ["have"] = "haz",
            ["know"] = "no",
            ["fore"] = "4",
            ["for"] = "4",
            ["s"] = "z",

        };

        public static List<string> punctuation = new List<string>()
        {
            ".",
            ",",
            "\'",
        };

        public static string N00bify(string text)
        {
            string noobified = text;

            foreach (var entry in punctuation)
                noobified = noobified.Replace(entry, "");

            foreach (var entry in NoobDict)
            {
                noobified = noobified.Replace(entry.Key, entry.Value);
                noobified = noobified.Replace(FirstCharacterCase(entry.Key), FirstCharacterCase(entry.Value));
            }

            if (noobified.ToLower().StartsWith('h'))
                noobified = noobified.ToUpper();
            if (noobified.ToLower().StartsWith('w'))
            {
                string addition = "LOL ";
                noobified = noobified.TrimEnd('!').TrimEnd('?').Length + addition.Length >= 32 ? "LOL OMG " + noobified : "LOL " + noobified;
            }
            else if (noobified.TrimEnd('!').TrimEnd('?').Length >= 32)
                noobified = "OMG " + noobified;

            string[] words = noobified.Split(' ');
            int numberOfWords = words.Length;

            noobified = "";

            for (int i = 0; i < numberOfWords; i++)
            {
                if (!(i % 2 == 0))
                    words[i] = words[i].ToUpper();

                noobified = noobified + " " + words[i];
            }

            string questionMarks = "";
            string exclamationMarks = "";

            if (noobified.Contains('?') || noobified.Contains('!'))
            {
                for (int i = 0; i < numberOfWords; i++)
                {
                    questionMarks = questionMarks + "?";
                    exclamationMarks = (!(i % 2 == 0) ? exclamationMarks + "1" : exclamationMarks + "!");
                }
            }

            noobified = noobified.Replace("?", questionMarks);
            noobified = noobified.Replace("!", exclamationMarks);
            
            return noobified.TrimStart();
        }

        public static string FirstCharacterCase(string input)
        {
            return input.ToUpper().Substring(0, 1) + input.Substring(1);
        }
    }
}
