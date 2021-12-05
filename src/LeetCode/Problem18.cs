namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/validate-binary-search-tree/">Validate Binary Search Tree</see>.
/// </summary>
public static class Problem18
{
    /// <summary>
    /// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">BST's root.</param>
    /// <returns>True, if the BST is valid.</returns>
    public static bool IsValidBST(TreeNode root)
    => IsValidBST(root, null, null);

    private static bool IsValidBST(TreeNode node, int? min, int? max)
    => (min == null || node.Val > min)
    && (max == null || node.Val < max)
    && (node.Left == null || IsValidBST(node.Left, min, node.Val))
    && (node.Right == null || IsValidBST(node.Right, node.Val, max));
}
