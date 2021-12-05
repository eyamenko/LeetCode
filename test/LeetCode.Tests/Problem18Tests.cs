namespace LeetCode.Tests;

using Xunit;

public class Problem18Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(2, 1, 3), true },
        new object[] { new TreeNode(5, 1, 4, 0, 0, 3, 6), false },
        new object[] { new TreeNode(5, 4, 6, 0, 0, 3, 7), false },
        new object[] { new TreeNode(2147483647), true },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void IsValidBST_should_determine_if_tree_is_valid_BST(TreeNode root, bool expected)
    {
        var actual = Problem18.IsValidBST(root);

        Assert.Equal(expected, actual);
    }
}
