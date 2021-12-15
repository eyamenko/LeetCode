namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/pacific-atlantic-water-flow/">Pacific Atlantic Water Flow</see>.
/// </summary>
#pragma warning disable CA1814
public static class Problem49
{
    /// <summary>
    /// There is an m x n rectangular island that borders both the Pacific Ocean and Atlantic Ocean.
    /// The Pacific Ocean touches the island's left and top edges, and the Atlantic Ocean touches the island's right and bottom edges.
    /// The island is partitioned into a grid of square cells.
    /// You are given an m x n integer matrix heights where heights[r][c] represents the height above sea level of the cell at coordinate (r, c).
    /// The island receives a lot of rain, and the rain water can flow to neighboring cells directly north, south, east,
    /// and west if the neighboring cell's height is less than or equal to the current cell's height.
    /// Water can flow from any cell adjacent to an ocean into the ocean.
    /// Return a 2D list of grid coordinates result where result[i] = [ri, ci] denotes that rain water can flow from cell (ri, ci) to both the Pacific and Atlantic oceans.
    /// Time complexity: O(m * n).
    /// Space complexity: O(m * n).
    /// </summary>
    /// <param name="heights">Array to traverse.</param>
    /// <returns>Grid coordinates.</returns>
    public static IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var result = new List<IList<int>>();
        var pacific = new bool[heights.Length, heights[0].Length];
        var atlantic = new bool[heights.Length, heights[0].Length];

        for (int m = 0, n = 0; n < heights[m].Length; n++)
        {
            Traverse(heights, m, n, heights[m][n], pacific);
        }

        for (int m = 0, n = 0; m < heights.Length; m++)
        {
            Traverse(heights, m, n, heights[m][n], pacific);
        }

        for (int m = 0, n = heights[m].Length - 1; m < heights.Length; m++)
        {
            Traverse(heights, m, n, heights[m][n], atlantic);
        }

        for (int m = heights.Length - 1, n = 0; n < heights[m].Length; n++)
        {
            Traverse(heights, m, n, heights[m][n], atlantic);
        }

        for (var m = 0; m < heights.Length; m++)
        {
            for (var n = 0; n < heights[m].Length; n++)
            {
                if (pacific[m, n] && atlantic[m, n])
                {
                    result.Add(new List<int> { m, n });
                }
            }
        }

        return result;
    }

    private static void Traverse(int[][] heights, int m, int n, int height, bool[,] dp)
    {
        if (m < 0 || n < 0 || m >= heights.Length || n >= heights[m].Length || dp[m, n] || heights[m][n] < height)
        {
            return;
        }

        dp[m, n] = true;

        Traverse(heights, m + 1, n, heights[m][n], dp);
        Traverse(heights, m - 1, n, heights[m][n], dp);
        Traverse(heights, m, n + 1, heights[m][n], dp);
        Traverse(heights, m, n - 1, heights[m][n], dp);
    }
}
#pragma warning restore CA1814
