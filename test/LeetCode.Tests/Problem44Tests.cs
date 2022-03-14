namespace LeetCode.Tests;

using Xunit;

public class Problem44Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new TreeNode(1, 2, 3, null, null, 4, 5), new TreeNode(1, 2, 3, null, null, 4, 5) },
        new object[] { new TreeNode(1), new TreeNode(1) },
        new object[] { new TreeNode(1, 2), new TreeNode(1, 2) },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void Serialize_and_Deserialize_should_serialize_and_deserialize_binary_tree(TreeNode root, TreeNode expected)
    {
        var actual = Problem44.Deserialize(Problem44.Serialize(root));

        Assert.Equal(expected, actual);
    }
}
