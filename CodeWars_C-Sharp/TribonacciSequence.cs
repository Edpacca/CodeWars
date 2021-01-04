using System.Linq;

// Well, you may have guessed it by now, but to be clear: you need to create a fibonacci function that given a signature array/list, returns the first n elements - signature included of the so seeded sequence.
// Signature will always contain 3 numbers; n will always be a non-negative number; if n == 0, then return an empty array(except in C return NULL) and be ready for anything else which is not clearly specified ;)

namespace CodeWars
{
    class TribonacciSequence
    {
        public static double[] Tribonacci(double[] signature, int n)
        {
            var tribonaccified = new double[n];

            if (n == 0)
                return tribonaccified;

            else if (n < 3)
            {
                for (int i = 0; i < n; i++)
                    tribonaccified[i] = signature[i];

                return tribonaccified;
            }

            for (int i = 0; i < 3; i++)
                tribonaccified[i] = signature[i];

            for (int i = 3; i < n; i++)
                tribonaccified[i] = tribonaccified.ToList().Skip(i - 3).Take(3).Sum();

            return tribonaccified;
        }
    }
}
