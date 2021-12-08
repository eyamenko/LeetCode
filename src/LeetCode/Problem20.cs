namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/binary-tree-level-order-traversal/">Binary Tree Level Order Traversal</see>.
/// </summary>
public static class Problem20
{
    /// <summary>
    /// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">Binary tree root.</param>
    /// <returns>Traversed values.</returns>
    public static IList<IList<int>> LevelOrder(TreeNode? root)
    {
        var result = new List<IList<int>>();

        Traverse(root, 0, result);

        return result;
    }

    private static void Traverse(TreeNode? node, int level, IList<IList<int>> result)
    {
        if (node == null)
        {
            return;
        }

        if (level == result.Count)
        {
            result.Add(new List<int>());
        }

        result[level].Add(node.Val);

        Traverse(node.Left, level + 1, result);
        Traverse(node.Right, level + 1, result);
    }
}
