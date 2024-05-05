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
        /// Calculates all unique combinations of coin representations for a given sum.
        /// </summary>
        /// <param name="coinDenominations">The list of available coin denominations.</param>
        /// <param name="targetSum">The target sum for which combinations are to be calculated.</param>
        /// <returns>A list containing all unique combinations of coin representations.</returns>
        public static List<List<long>> CalculateCombinations(List<long> coinDenominations, long targetSum)
        {
            var combinations = new HashSet<List<long>>(); // Use HashSet for efficient duplicate checking
            GenerateCombinations(coinDenominations, 0, new List<long>(), targetSum, combinations);
            return combinations.ToList();
        }

        /// <summary>
        /// Recursive method to generate combinations of coin representations.
        /// </summary>
        private static void GenerateCombinations(List<long> coinDenominations, int index, List<long> currentCombination, long remainingSum, HashSet<List<long>> combinations)
        {
            // Checks if combination found
            if (remainingSum == 0)
            {
                // Checks if the combination is already in the list
                if (!combinations.Any(c => c.SequenceEqual(currentCombination)))
                {
                    combinations.Add(new List<long>(currentCombination));
                }
                return;
            }

            if (index >= coinDenominations.Count || remainingSum < 0)
            {
                return;
            }

            // Include the current coin denomination
            currentCombination.Add(coinDenominations[index]);
            GenerateCombinations(coinDenominations, index + 1, currentCombination, remainingSum - coinDenominations[index], combinations);
            currentCombination.RemoveAt(currentCombination.Count - 1); // Backtrack

            // Exclude the current coin denomination
            GenerateCombinations(coinDenominations, index + 1, currentCombination, remainingSum, combinations);
        }

        /// <summary>
        /// Solves the problem of calculating the number of unique combinations for a given sum.
        /// </summary>
        /// <param name="sum">The target sum for which unique combinations are to be calculated.</param>
        /// <returns>The number of unique combinations for the given sum.</returns>
        public static long Solve(long sum)
        {
            List<long> coinDenominations = GenerateCoinDenominations(sum);
            List<List<long>> combinations = CalculateCombinations(coinDenominations, sum);

            return combinations.Count;
        }

        /// <summary>
        /// Generates a list of coin denominations based on the given sum.
        /// </summary>
        private static List<long> GenerateCoinDenominations(long sum)
        {
            List<long> coinDenominations = new List<long>();
            int closestLog2Index = (int)Math.Floor(Math.Log(sum, 2));

            // Adds two of each coin with a denomination equal to 2 raised to the power of 'i' for each 'i' from the closest power of 2 to zero.
            for (int i = closestLog2Index; i >= 0; i--)
            {
                coinDenominations.Add((long)Math.Pow(2, i));
                coinDenominations.Add((long)Math.Pow(2, i));
            }
            return coinDenominations;
        }
    }
}
