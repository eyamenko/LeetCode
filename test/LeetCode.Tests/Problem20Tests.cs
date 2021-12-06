namespace LeetCode.Tests;

using Xunit;

public class Problem20Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(3, 9, 20, null, null, 15, 7), new[] { new[] { 3 }, new[] { 9, 20 }, new[] { 15, 7 } } },
        new object[] { new TreeNode(1), new[] { new[] { 1 } } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void LevelOrder_should_traverse_all_nodes_level_by_level(TreeNode root, int[][] expected)
    {
        var actual = Problem20.LevelOrder(root);

        Assert.Equal(expected.Length, actual.Count);

        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
    }
}
