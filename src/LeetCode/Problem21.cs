namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/maximum-depth-of-binary-tree/">Maximum Depth of Binary Tree</see>.
/// </summary>
public static class Problem21
{
    /// <summary>
    /// Given the root of a binary tree, return its maximum depth.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">Binary tree's root.</param>
    /// <returns>Maximum depth of the binary tree.</returns>
    public static int MaxDepth(TreeNode? root) => Traverse(root, 0);

    private static int Traverse(TreeNode? node, int depth)
    {
        if (node == null)
        {
            return depth;
        }

        return Math.Max(Traverse(node.Left, depth + 1), Traverse(node.Right, depth + 1));
    }
}
