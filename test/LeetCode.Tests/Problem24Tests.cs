namespace LeetCode.Tests;

using Xunit;

public class Problem24Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(1, 2, 3), 6 },
        new object[] { new TreeNode(-10, 9, 20, null, null, 15, 7), 42 },
        new object[] { new TreeNode(-1, -2, -3, 1, 3, -2, null, -1), 3 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxPathSum_should_find_maximum_path_sum_of_any_non_empty_path(TreeNode root, int expected)
    {
        var actual = Problem24.MaxPathSum(root);

        Assert.Equal(expected, actual);
    }
}
