using System.Collections.Generic;
using System.Linq;

// https://www.codewars.com/kata/55e7280b40e1c4a06d0000aa
//John and Mary want to travel between a few towns A, B, C ... Mary has on a sheet of paper a list of distances between these towns. ls = [50, 55, 57, 58, 60]. 
// John is tired of driving and he says to Mary that he doesn't want to drive more than t = 174 miles and he will visit only 3 towns.
// Which distances, hence which towns, they will choose so that the sum of the distances is the biggest possible to please Mary and John?

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
