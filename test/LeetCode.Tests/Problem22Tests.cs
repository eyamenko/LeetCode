namespace LeetCode.Tests;

using Xunit;

public class Problem22Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 3, 9, 20, 15, 7 }, new[] { 9, 3, 15, 20, 7 }, new TreeNode(3, 9, 20, null, null, 15, 7) },
        new object[] { new[] { -1 }, new[] { -1 }, new TreeNode(-1) },
        new object[] { new[] { 1, 2, 4, 8, 9, 5, 10, 11, 3, 6, 12, 13, 7, 14, 15 }, new[] { 8, 4, 9, 2, 10, 5, 11, 1, 12, 6, 13, 3, 14, 7, 15 }, new TreeNode(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15) },
        new object[] { new[] { 1, 2 }, new[] { 2, 1 }, new TreeNode(1, 2) },
        new object[] { new[] { 1, 2 }, new[] { 1, 2 }, new TreeNode(1, null, 2) },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void BuildTree_should_construct_binary_tree(int[] preorder, int[] inorder, TreeNode expected)
    {
        var actual = Problem22.BuildTree(preorder, inorder);

        Assert.Equal(expected, actual);
    }
}
