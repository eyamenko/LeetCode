namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/number-of-islands/">Number of Islands</see>.
/// </summary>
public static class Problem32
{
    /// <summary>
    /// Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
    /// An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
    /// You may assume all four edges of the grid are all surrounded by water.
    /// Time complexity: O(m * n).
    /// Space complexity: O(m * n).
    /// </summary>
    /// <param name="grid">Array to traverse.</param>
    /// <returns>Number of islands.</returns>
    public static int NumIslands(char[][] grid)
    {
        var count = 0;

        for (var m = 0; m < grid.Length; m++)
        {
            for (var n = 0; n < grid[m].Length; n++)
            {
                if (grid[m][n] == '1')
                {
                    count++;
                    Traverse(grid, m, n);
                }
            }
        }

        return count;
    }

    private static void Traverse(char[][] grid, int m, int n)
    {
        if (m >= 0 && m < grid.Length && n >= 0 && n < grid[m].Length && grid[m][n] == '1')
        {
            grid[m][n] = '*';

            Traverse(grid, m + 1, n);
            Traverse(grid, m - 1, n);
            Traverse(grid, m, n + 1);
            Traverse(grid, m, n - 1);
        }
    }
}
