using System;
using System.Collections.Generic;

// In this kata, you will write a function that returns the positions and the values of the "peaks" (or local maxima) of a numeric array.

namespace CodeWars
{
    class PickPeaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var dict = new Dictionary<string, List<int>>();

            if (arr.Length == 0 || arr.Length == 1 || arr.Length == 2)
            {
                dict.Add("pos", new List<int>());
                dict.Add("peaks", new List<int>());
                return dict;
            }

            var pos = new List<int>();
            var peaks = new List<int>();

            for (int i = 1; i < arr.Length - 1; i++)
            {
                var j = i + 1;
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    peaks.Add(arr[i]);
                    pos.Add(i);
                }

                // Potential plateua
                else if (arr[i] > arr[i - 1] && arr[i] == arr[i + 1] && j < arr.Length - 1)
                {
                    do
                        j++;
                    while (j < arr.Length - 1 && arr[j] == arr[i + 1]);

                    if (arr[i] > arr[j])
                    {
                        peaks.Add(arr[i]);
                        pos.Add(i);
                    }
                }
            }

            dict.Add("pos", pos);
            dict.Add("peaks", peaks);

            for (int i = 0; i < pos.Count; i++)
                Console.WriteLine("pos: {0} peak: {1}", pos[i], peaks[i]);

            return dict;
        }
    }
}
