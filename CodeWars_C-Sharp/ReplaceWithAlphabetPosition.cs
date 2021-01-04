using System.Text;

// In this kata you are required to, given a string, replace every letter with its position in the alphabet.
// If anything in the text isn't a letter, ignore it and don't return it.

namespace CodeWars
{
    class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            var positions = new StringBuilder();

            foreach (var letter in text.ToLower())
            {
                if ((int)letter >= 97 && (int)letter <= 122)
                    positions
                        .Append((int)letter - 96)
                        .Append(" ");
            }

            return positions.ToString();
        }
    }
}
