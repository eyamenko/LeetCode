namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/same-tree/">Same Tree</see>.
/// </summary>
public static class Problem19
{
    /// <summary>
    /// Given the roots of two binary trees p and q, write a function to check if they are the same or not.
    /// Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="p">Binary tree p.</param>
    /// <param name="q">Binary tree q.</param>
    /// <returns>True, if binary trees are equal.</returns>
    public static bool IsSameTree(TreeNode? p, TreeNode? q)
    => (p == null && q == null) || (p != null && q != null && p.Val == q.Val && IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right));
}
