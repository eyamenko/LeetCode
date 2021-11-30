namespace LeetCode.Tests;

using Xunit;

public class Problem3Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49 },
        new object[] { new[] { 1, 1 }, 1 },
        new object[] { new[] { 4, 3, 2, 1, 4 }, 16 },
        new object[] { new[] { 1, 2, 1 }, 2 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxArea_should_find_max_area_of_water_container_can_contain(int[] height, int expected)
    {
        var actual = Problem3.MaxArea(height);

        Assert.Equal(expected, actual);
    }
}
