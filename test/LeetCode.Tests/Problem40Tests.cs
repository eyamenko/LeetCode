namespace LeetCode.Tests;

using Xunit;

public class Problem40Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(6, 2, 8, 0, 4, 7, 9, null, null, 3, 5), new TreeNode(2), new TreeNode(8), new TreeNode(6, 2, 8, 0, 4, 7, 9, null, null, 3, 5) },
        new object[] { new TreeNode(6, 2, 8, 0, 4, 7, 9, null, null, 3, 5), new TreeNode(2), new TreeNode(4), new TreeNode(2, 0, 4, null, null, 3, 5) },
        new object[] { new TreeNode(2, 1), new TreeNode(2), new TreeNode(1), new TreeNode(2, 1) },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void LowestCommonAncestor_should_find_lowest_common_ancestor_of_tow_given_nodes(TreeNode root, TreeNode p, TreeNode q, TreeNode expected)
    {
        var actual = Problem40.LowestCommonAncestor(root, p, q);

        Assert.Equal(expected, actual);
    }
}
