using System.Linq;

namespace CodeWars
{
    class SumLowestPositiveIntegers
    {
        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            return numbers.OrderBy(x => x).Take(2).Sum();
        }

    }
}
