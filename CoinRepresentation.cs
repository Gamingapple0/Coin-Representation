using System;

namespace CoinRepresentation
{
    /// <summary>
    /// Provides methods for solving the coin representation problem.
    /// </summary>
    public class CoinRepresentation
    {
        /// <summary>
        /// Solves the coin representation problem for the given value.
        /// </summary>
        /// <param name="value">The value to represent using coins.</param>
        /// <returns>The minimum number of coins required to represent the value.</returns>
        public static int Solve(long value)
        {
            int coinCount = 0;
            long coinValue = 1;

            while (value > 0)
            {
                // If the value is greater than or equal to the current power of 2
                if (value >= coinValue)
                {
                    value -= coinValue;
                    coinCount++;
                }
                coinValue <<= 1; // Double the coin value for the next iteration
            }

            return coinCount;
        }
    }
}
