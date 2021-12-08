namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/binary-tree-maximum-path-sum/">Binary Tree Maximum Path Sum</see>.
/// </summary>
public static class Problem24
{
    private static int globalSum;

    /// <summary>
    /// A path in a binary tree is a sequence of nodes where each pair of adjacent nodes in the sequence has an edge connecting them.
    /// A node can only appear in the sequence at most once. Note that the path does not need to pass through the root.
    /// The path sum of a path is the sum of the node's values in the path.
    /// Given the root of a binary tree, return the maximum path sum of any non-empty path.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">Binary tree root.</param>
    /// <returns>Maximum path sum of any non-empty path.</returns>
    public static int MaxPathSum(TreeNode root)
    {
        globalSum = root.Val;

        Traverse(root);

        return globalSum;
    }

    private static int Traverse(TreeNode? node)
    {
        if (node == null)
        {
            return 0;
        }

        var leftSum = Traverse(node.Left);
        var rightSum = Traverse(node.Right);
        var currentSum = node.Val + Math.Max(Math.Max(leftSum, rightSum), 0);

        globalSum = Math.Max(globalSum, currentSum + Math.Max(Math.Min(leftSum, rightSum), 0));

        return currentSum;
    }
}
