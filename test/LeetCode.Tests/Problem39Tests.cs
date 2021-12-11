namespace LeetCode.Tests;

using Xunit;

public class Problem39Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(3, 1, 4, null, 2), 1, 1 },
        new object[] { new TreeNode(5, 3, 6, 2, 4, null, null, 1), 3, 3 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void KthSmallest_should_find_kth_smallest_element(TreeNode root, int k, int expected)
    {
        var actual = Problem39.KthSmallest(root, k);

        Assert.Equal(expected, actual);
    }
}
