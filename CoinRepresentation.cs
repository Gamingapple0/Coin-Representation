using System;

namespace CoinRepresentation
{
    /// <summary>
    /// Provides methods for solving the coin representation problem.
    /// </summary>
    public class CoinRepresentation
    {
        /// <summary>
        /// Solves the coin representation problem for a given sum.
        /// </summary>
        /// <param name="sum">The target sum to represent using coins.</param>
        /// <returns>The number of possible ways to represent the sum using coins.</returns>
        public static long Solve(long sum)
        {
            // If sum is negative, no coins and no sum possible
            if (sum < 0) return 0;

            // If sum is 0, complete combination found
            if (sum == 0) return 1;

            return CountRepresentationsHelper(sum);
        }

        /// <summary>
        /// Helper method to recursively count coin representations.
        /// </summary>
        /// <param name="remainingSum">The remaining sum to represent using coins.</param>
        /// <returns>The number of possible ways to represent the remaining sum using coins.</returns>
        private static long CountRepresentationsHelper(long remainingSum)
        {
            // If remaining sum is even
            if (remainingSum % 2 == 0)
            {
                // Recursively solve for half the remaining sum and half the remaining sum minus one
                return Solve(remainingSum / 2) + Solve(remainingSum / 2 - 1);
            }
            else // If remaining sum is odd
            {
                // Recursively solve for half the remaining sum minus one
                return Solve((remainingSum - 1) / 2);
            }
        }
    }
}
