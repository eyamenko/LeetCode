namespace LeetCode.Tests;

using Xunit;

public class Problem49Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { new[] { 1, 2, 2, 3, 5 }, new[] { 3, 2, 3, 4, 4 }, new[] { 2, 4, 5, 3, 1 }, new[] { 6, 7, 1, 4, 5 }, new[] { 5, 1, 1, 2, 4 } }, new[] { new[] { 0, 4 }, new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 2 }, new[] { 3, 0 }, new[] { 3, 1 }, new[] { 4, 0 } } },
        new object[] { new[] { new[] { 2, 1 }, new[] { 1, 2 } }, new[] { new[] { 0, 0 }, new[] { 0, 1 }, new[] { 1, 0 }, new[] { 1, 1 } } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void PacificAtlantic_should_find_grid_coordinates(int[][] heights, int[][] expected)
    {
        var actual = Problem49.PacificAtlantic(heights);

        Assert.Equal(expected.Length, actual.Count);

        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
    }
}
