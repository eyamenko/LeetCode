namespace LeetCode.Tests;

using Xunit;

public class Problem26Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new GraphNode(new[] { 2, 4 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 1, 3 }), new GraphNode(new[] { 2, 4 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 1, 3 }) },
        new object[] { new GraphNode(), new GraphNode() },
        new object[] { new GraphNode(new[] { 2 }, new[] { 1 }), new GraphNode(new[] { 2 }, new[] { 1 }) },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void CloneGraph_should_produce_deep_copy_of_graph(GraphNode node, GraphNode expected)
    {
        var actual = Problem26.CloneGraph(node);

        Assert.Equal(expected, actual);
    }
}
