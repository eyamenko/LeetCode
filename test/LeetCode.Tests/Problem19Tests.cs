namespace LeetCode.Tests;

using Xunit;

public class Problem19Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(1, 2, 3), new TreeNode(1, 2, 3), true },
        new object[] { new TreeNode(1, 2), new TreeNode(1, null, 2), false },
        new object[] { new TreeNode(1, 2, 1), new TreeNode(1, 1, 2), false },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void IsSameTree_should_determine_whether_binary_trees_are_equal(TreeNode p, TreeNode q, bool expected)
    {
        var actual = Problem19.IsSameTree(p, q);

        Assert.Equal(expected, actual);
    }
}
