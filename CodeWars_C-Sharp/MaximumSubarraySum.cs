// The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:
// Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. If the list is made up of only negative numbers, return 0 instead.
// Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.

namespace CodeWars
{
    class MaximumSubarraySum
    {
        public static int MaxSequence(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            var sum = 0;
            var max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum > max)
                        max = sum;
                }

                sum = 0;
            }

            return max;
        }
    }
}
