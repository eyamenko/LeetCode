namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/best-time-to-buy-and-sell-stock/">Best Time to Buy and Sell Stock</see>.
/// </summary>
public static class Problem23
{
    /// <summary>
    /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
    /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    /// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="prices">Array to traverse.</param>
    /// <returns>Maximum possible profit.</returns>
    public static int MaxProfit(int[] prices)
    {
        var maxProfit = 0;

        if (prices.Length == 0)
        {
            return maxProfit;
        }

        for (int i = 1, minValue = prices[0]; i < prices.Length; i++)
        {
            minValue = Math.Min(minValue, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minValue);
        }

        return maxProfit;
    }
}
