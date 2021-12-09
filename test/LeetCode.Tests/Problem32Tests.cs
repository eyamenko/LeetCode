namespace LeetCode.Tests;

using Xunit;

public class Problem32Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { new[] { '1', '1', '1', '1', '0' }, new[] { '1', '1', '0', '1', '0' }, new[] { '1', '1', '0', '0', '0' }, new[] { '0', '0', '0', '0', '0' } }, 1 },
        new object[] { new[] { new[] { '1', '1', '0', '0', '0' }, new[] { '1', '1', '0', '0', '0' }, new[] { '0', '0', '1', '0', '0' }, new[] { '0', '0', '0', '1', '1' } }, 3 },
        new object[] { new[] { new[] { '1', '1', '1' }, new[] { '0', '1', '0' }, new[] { '1', '1', '1' } }, 1 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void NumIslands_should_find_number_of_islands(char[][] grid, int expected)
    {
        var actual = Problem32.NumIslands(grid);

        Assert.Equal(expected, actual);
    }
}
