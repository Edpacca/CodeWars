using System;
using System.Collections.Generic;

// Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in descending order. Essentially, rearrange the digits to create the highest possible number.

namespace CodeWars
{
    class DescendingOrder
    {
        public static int DescendingOrderSolution(int num)
        {
            var numberList = new List<int>();

            while (num > 0)
            {
                numberList.Add(num % 10);
                num = num / 10;
            }

            numberList.Sort();
            var largestNum = 0;

            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                largestNum += numberList[i] * Convert.ToInt32((Math.Pow(10, (float)i)));
            }

            return largestNum;
        }
    }
}
