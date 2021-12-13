namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/coin-change/">Coin Change</see>.
/// </summary>
public static class Problem46
{
    /// <summary>
    /// You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.
    /// Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.
    /// You may assume that you have an infinite number of each kind of coin.
    /// Time complexity: O(n * a).
    /// Space complexity: O(n + a).
    /// </summary>
    /// <param name="coins">Coins.</param>
    /// <param name="amount">Amount.</param>
    /// <returns>Fewest number of coins that is needed to make up the amount.</returns>
    public static int CoinChange(int[] coins, int amount)
    {
        var results = new int[amount];

        return Traverse(coins, amount, results);
    }

    private static int Traverse(int[] coins, int amount, int[] results)
    {
        if (amount == 0)
        {
            return 0;
        }

        var index = amount - 1;

        if (results[index] != 0)
        {
            return results[index];
        }

        var minCoins = int.MaxValue;

        for (var i = 0; i < coins.Length; i++)
        {
            if (coins[i] <= amount)
            {
                var subResult = Traverse(coins, amount - coins[i], results);

                if (subResult >= 0)
                {
                    minCoins = Math.Min(minCoins, subResult + 1);
                }
            }
        }

        return results[index] = minCoins == int.MaxValue ? -1 : minCoins;
    }
}
