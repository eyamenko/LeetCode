namespace LeetCode.Tests;

using Xunit;

public class Problem14Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { 3, 7, 28 },
        new object[] { 3, 2, 3 },
        new object[] { 7, 3, 28 },
        new object[] { 3, 3, 6 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void UniquePaths_should_find_number_of_unique_paths(int m, int n, int expected)
    {
        var actual = Problem14.UniquePaths(m, n);

        Assert.Equal(expected, actual);
    }
}
