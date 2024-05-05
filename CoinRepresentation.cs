using System;
using System.Collections.Generic;
using System.Linq;

namespace CoinRepresentation
{
    /// <summary>
    /// Provides methods for calculating unique combinations of coin representations for a given sum.
    /// </summary>
    public class CoinRepresentation
    {
        /// <summary>
        /// Dictionary to store memoization values for faster computation.
        /// </summary>
        private static Dictionary<string, HashSet<List<long>>> memoization = new Dictionary<string, HashSet<List<long>>>();

        /// <summary>
        /// Calculates all unique combinations of coin representations for a given sum.
        /// </summary>
        /// <param name="coinDenominations">List of coin denominations.</param>
        /// <param name="targetSum">Target sum to find combinations for.</param>
        /// <returns>List of all unique combinations of coin representations.</returns>
        public static List<List<long>> CalculateCombinations(List<long> coinDenominations, long targetSum)
        {
            var combinations = new HashSet<List<long>>(); // Use HashSet for efficient duplicate checking
            GenerateCombinations(coinDenominations, 0, new List<long>(), targetSum, combinations);
            return combinations.ToList();
        }

        /// <summary>
        /// Recursive function to generate all unique combinations of coin representations.
        /// </summary>
        /// <param name="coinDenominations">List of coin denominations.</param>
        /// <param name="index">Current index in the list of coin denominations.</param>
        /// <param name="currentCombination">Current combination being formed.</param>
        /// <param name="remainingSum">Remaining sum to be achieved.</param>
        /// <param name="combinations">Set to store unique combinations.</param>
        private static void GenerateCombinations(List<long> coinDenominations, int index, List<long> currentCombination, long remainingSum, HashSet<List<long>> combinations)
        {
            string key = $"{index},{remainingSum},{string.Join(",", currentCombination)}";

            // Checks if the key is already in memo
            if (memoization.ContainsKey(key))
            {
                combinations.UnionWith(memoization[key]);
                return;
            }

            // Checks if combination found
            if (remainingSum == 0)
            {
                // Checks if the combination is already in the list
                if (!combinations.Any(lst => lst.SequenceEqual(currentCombination)))
                {
                    combinations.Add(new List<long>(currentCombination));
                }
                memoization[key] = new HashSet<List<long>>(combinations); 
                return;
            }

            if (index >= coinDenominations.Count || remainingSum < 0)
            {
                memoization[key] = new HashSet<List<long>>(combinations);
                return;
            }

            // Include the current coin denomination
            currentCombination.Add(coinDenominations[index]);
            GenerateCombinations(coinDenominations, index + 1, currentCombination, remainingSum - coinDenominations[index], combinations);
            currentCombination.RemoveAt(currentCombination.Count - 1); // Backtrack

            // Exclude the current coin denomination
            GenerateCombinations(coinDenominations, index + 1, currentCombination, remainingSum, combinations);

            memoization[key] = new HashSet<List<long>>(combinations);
        }

        /// <summary>
        /// Solves the problem of finding the number of unique combinations for a given sum.
        /// </summary>
        /// <param name="targetSum">Target sum to find combinations for.</param>
        /// <returns>The number of unique combinations for the given sum.</returns>
        public static long Solve(long targetSum)
        {
            List<long> powersOfTwo = new List<long>();
            int closestLog2Index = (int)Math.Floor(Math.Log(targetSum, 2));

            for (int i = closestLog2Index; i >= 0; i--)
            {
                powersOfTwo.Add((long)Math.Pow(2, i));
                powersOfTwo.Add((long)Math.Pow(2, i));
            }

            List<List<long>> combinations = CalculateCombinations(powersOfTwo, targetSum);

            return combinations.Count;
        }
    }
}
