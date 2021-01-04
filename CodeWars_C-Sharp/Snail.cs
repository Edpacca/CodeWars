using System;
using System.Collections.Generic;

// Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.
// NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.
// NOTE 2: The 0x0(empty matrix) is represented as en empty array inside an array [[]].

namespace CodeWars
{
    class Snail
    {
        public static int[] SnailSolution(int[][] array)
        {
            if (array == null)
                return new int[0];

            var returnArray = new List<int>();
            var Ylen = array.Length - 1;
            var Xlen = array[0].Length - 1;
            var elements = array.Length * array[0].Length;
            var c = 0;

            while (returnArray.Count != elements)
            {
                for (int i = 0 + c; i <= Xlen - c; i++)
                {
                    Console.WriteLine(array[0 + c][i]);
                    returnArray.Add(array[0 + c][i]);
                }

                if (returnArray.Count == elements)
                    break;

                for (int i = 1 + c; i <= Ylen - c; i++)
                {
                    Console.WriteLine(array[i][Xlen - c]);
                    returnArray.Add(array[i][Xlen - c]);
                }

                if (returnArray.Count == elements)
                    break;

                for (int i = Xlen - 1 - c; i >= 0 + c; i--)
                {
                    Console.WriteLine(array[Ylen - c][i]);
                    returnArray.Add(array[Ylen - c][i]);
                }

                if (returnArray.Count == elements)
                    break;

                for (int i = Ylen - 1 - c; i >= 1 + c; i--)
                {
                    Console.WriteLine(array[i][0 + c]);
                    returnArray.Add(array[i][0 + c]);

                }

                c++;
            }

            return returnArray.ToArray();
        }
    }
}
