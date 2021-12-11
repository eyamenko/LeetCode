namespace LeetCode.Tests;

using Xunit;

public class Problem38Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(4, 2, 7, 1, 3, 6, 9), new TreeNode(4, 7, 2, 9, 6, 3, 1) },
        new object[] { new TreeNode(2, 1, 3), new TreeNode(2, 3, 1) },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void InvertTree_should_invert_binary_tree(TreeNode root, TreeNode expected)
    {
        var actual = Problem38.InvertTree(root);

        Assert.Equal(expected, actual);
    }
}
