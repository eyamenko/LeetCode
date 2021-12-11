namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/invert-binary-tree/">Invert Binary Tree</see>.
/// </summary>
public static class Problem38
{
    /// <summary>
    /// Given the root of a binary tree, invert the tree, and return its root.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">Binary tree to invert.</param>
    /// <returns>Inverted binary tree.</returns>
    public static TreeNode? InvertTree(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }

        (root.Left, root.Right) = (InvertTree(root.Right), InvertTree(root.Left));

        return root;
    }
}
