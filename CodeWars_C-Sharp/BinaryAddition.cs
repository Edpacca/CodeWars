using System.Text;

// Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.
// The binary number returned should be a string.

namespace CodeWars
{
    class BinaryAddition
    {
        public static string AddBinary(int a, int b)
        {
            var sum = a + b;
            var square = 1;
            var squares = 1;

            while (sum > square)
            {
                square *= 2;
                squares++;
            }

            var binaryValues = new int[squares];
            var binaryString = new StringBuilder();

            for (int i = 0; i < squares; i++)
            {
                if (sum >= square)
                {
                    binaryValues[i] = 1;
                    sum -= square;
                }
                square /= 2;
                binaryString.Append(binaryValues[i]);
            }

            return binaryString.ToString().TrimStart(new char[] { '0' });
        }
    }
}
