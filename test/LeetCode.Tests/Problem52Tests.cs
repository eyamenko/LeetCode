namespace LeetCode.Tests;

using Xunit;

public class Problem52Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(3, 4, 5, 1, 2), new TreeNode(4, 1, 2), true },
        new object[] { new TreeNode(3, 4, 5, 1, 2, null, null, null, null, 0), new TreeNode(4, 1, 2), false },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void IsSubtree_should_indicate_whether_binary_tree_contains_provided_subtree(TreeNode root, TreeNode subRoot, bool expected)
    {
        var actual = Problem52.IsSubtree(root, subRoot);

        Assert.Equal(expected, actual);
    }
}
