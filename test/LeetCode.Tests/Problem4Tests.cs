namespace LeetCode.Tests;

using Xunit;

public class Problem4Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { -1, 0, 1, 2, -1, -4 }, new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } } },
        new object[] { Array.Empty<int>(), Array.Empty<int[]>() },
        new object[] { new[] { 0 }, Array.Empty<int[]>() },
        new object[] { new[] { 0, 0, 0, 0 }, new[] { new[] { 0, 0, 0 } } },
        new object[] { new[] { -2, 1, 1 }, new[] { new[] { -2, 1, 1 } } },
        new object[] { new[] { -1, -1, 2 }, new[] { new[] { -1, -1, 2 } } },
        new object[] { new[] { -2, 0, 1, 1, 2 }, new[] { new[] { -2, 0, 2 }, new[] { -2, 1, 1 } } },
        new object[] { new[] { -1, 0, 0, 1 }, new[] { new[] { -1, 0, 1 } } },
        new object[] { new[] { -2, 0, 0, 2, 2 }, new[] { new[] { -2, 0, 2 } } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ThreeSum_should_find_triplets_that_add_up_to_zero(int[] nums, int[][] expected)
    {
        var actual = Problem4.ThreeSum(nums);

        Assert.Equal(expected.Length, actual.Count);

        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
    }
}
