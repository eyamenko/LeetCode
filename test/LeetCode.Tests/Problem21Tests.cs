namespace LeetCode.Tests;

using Xunit;

public class Problem21Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(3, 9, 20, null, null, 15, 7), 3 },
        new object[] { new TreeNode(1, null, 2), 2 },
        new object[] { new TreeNode(0), 1 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MaxDepth_should_find_maximum_depth_of_binary_tree(TreeNode root, int expected)
    {
        var actual = Problem21.MaxDepth(root);

        Assert.Equal(expected, actual);
    }
}
