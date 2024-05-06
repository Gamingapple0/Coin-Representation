using System;
using System.Collections.Generic;

namespace CoinRepresentation
{
    /// <summary>
    /// Provides methods for solving the coin representation problem.
    /// </summary>
    public class CoinRepresentation
    {
        private static Dictionary<long, long> _memo = new Dictionary<long, long>();

        /// <summary>
        /// Solves the coin representation problem for a given sum.
        /// </summary>
        /// <param name="targetSum">The target sum to represent using coins.</param>
        /// <returns>The number of possible ways to represent the sum using coins.</returns>
        public static long Solve(long targetSum)
        {
            if (targetSum < 0)
                return 0; // No coins and no sum possible for negative sum

            if (targetSum == 0)
                return 1; // Complete combination found for sum = 0

            if (_memo.ContainsKey(targetSum))
                return _memo[targetSum]; // Return result from memo if available

            long result = CountCoinRepresentations(targetSum); // Calculate result

            _memo[targetSum] = result; // Store result in memo
            return result;
        }

        /// <summary>
        /// Helper method to recursively count coin representations.
        /// </summary>
        /// <param name="remainingSum">The remaining sum to represent using coins.</param>
        /// <returns>The number of possible ways to represent the remaining sum using coins.</returns>
        private static long CountCoinRepresentations(long remainingSum)
        {
            if (remainingSum % 2 == 0)
            {
                // If remaining sum is even, recursively solve for half the remaining sum and half the remaining sum minus one
                return Solve(remainingSum / 2) + Solve(remainingSum / 2 - 1);
            }
            else
            {
                // If remaining sum is odd, recursively solve for half the remaining sum minus one
                return Solve((remainingSum - 1) / 2);
            }
        }
    }
}
