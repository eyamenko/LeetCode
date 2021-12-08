namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/clone-graph/">Clone Graph</see>.
/// </summary>
public static class Problem26
{
    /// <summary>
    /// Given a reference of a node in a connected undirected graph, return a deep copy (clone) of the graph.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="node">Graph node.</param>
    /// <returns>Cloned graph.</returns>
    public static GraphNode? CloneGraph(GraphNode? node)
    {
        if (node == null)
        {
            return null;
        }

        return Traverse(node, new Dictionary<int, GraphNode>());
    }

    private static GraphNode Traverse(GraphNode node, IDictionary<int, GraphNode> dict)
    {
        if (dict.ContainsKey(node.Val))
        {
            return dict[node.Val];
        }

        var newNode = new GraphNode(node.Val);

        dict.Add(node.Val, newNode);

        foreach (var neighbour in node.Neighbors)
        {
            newNode.Neighbors.Add(Traverse(neighbour, dict));
        }

        return newNode;
    }
}
