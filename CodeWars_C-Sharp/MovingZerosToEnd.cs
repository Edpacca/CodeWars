using System;
using System.Collections.Generic;

// Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

namespace CodeWars
{
    class MovingZerosToEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            var newList = new List<int>(arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    newList.Add(arr[i]);
            }

            Array.Clear(arr, 0, arr.Length);
            newList.CopyTo(arr);

            return arr;
        }
    }
}
