namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/unique-paths/">Unique Paths</see>.
/// </summary>
#pragma warning disable CA1814
public static class Problem14
{
    /// <summary>
    /// A robot is located at the top-left corner of a m x n grid.
    /// The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid.
    /// Find how many possible unique paths are there.
    /// Time complexity: O(m * n).
    /// Space complexity: O(m * n).
    /// </summary>
    /// <param name="m">Number of rows.</param>
    /// <param name="n">Number of columns.</param>
    /// <returns>Number of unique paths.</returns>
    public static int UniquePaths(int m, int n) => Traverse(new int[m, n], m - 1, n - 1, 0, 0);

    private static int Traverse(int[,] grid, int m, int n, int i, int j)
    {
        if (i > m || j > n)
        {
            return 0;
        }

        if (grid[i, j] > 0)
        {
            return grid[i, j];
        }

        if (m == i && n == j)
        {
            return grid[i, j] = 1;
        }

        return grid[i, j] = Traverse(grid, m, n, i + 1, j) + Traverse(grid, m, n, i, j + 1);
    }
}
#pragma warning restore CA1814
