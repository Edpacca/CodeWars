using System.Collections.Generic;
using System.Linq;
using System;

namespace CodeWars
{
    class BestTravel
    {
        public static int? chooseBestSum(int t, int k, List<int> ls)
        {
            int numberOfElements = ls.Count;
            List<List<int>> possibleCombinations = PossibleCombinations(numberOfElements, k);
            HashSet<int> distances = new HashSet<int>();

            foreach (var combination in possibleCombinations)
            {
                int distance = 0;

                for (int i = 0; i < k; i++)
                    distance += ls[combination[i]];
                
                distances.Add(distance);
            }

            int maxDistance = distances.Where(d => d <= t).DefaultIfEmpty().Max();

            if (maxDistance == 0)
                return null;
            else
                return maxDistance;
        }

        public static List<List<int>> PossibleCombinations(int listLength, int comboLength)
        {
            List<List<int>> allCombinations = new List<List<int>>();
            
            for (int i = 0; i <= listLength - comboLength; i++)
                PopulateCombinations(allCombinations, new int[comboLength], 0, i, listLength, comboLength);

            return allCombinations;
        }

        public static void PopulateCombinations(List<List<int>> combinations, int[] combination, int columnIndex, int nextValue, int listLength, int comboLength)
        {
            if (columnIndex < combination.Length - 1)
            {
                combination[columnIndex] = nextValue;

                for (int i = nextValue + 1; i < listLength; i++)
                {
                    PopulateCombinations(combinations, combination, columnIndex + 1, i, listLength, comboLength);
                }
            }
            else
            {
                for (int i = nextValue; i < listLength; i++)
                {
                    combination[columnIndex] = i;
                    combinations.Add(new List<int>(combination));
                }
            }
        }
    }
}
