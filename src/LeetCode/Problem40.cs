namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/">Lowest Common Ancestor of a Binary Search Tree</see>.
/// </summary>
public static class Problem40
{
    /// <summary>
    /// Given a binary search tree (BST), find the lowest common ancestor (LCA) of two given nodes in the BST.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">Binary search tree to traverse.</param>
    /// <param name="p">Node p.</param>
    /// <param name="q">Node q.</param>
    /// <returns>Lowest common ancestor of two given nodes.</returns>
    public static TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode p, TreeNode q)
    {
        if (root == null)
        {
            return null;
        }

        if (p.Val < root.Val && q.Val < root.Val)
        {
            return LowestCommonAncestor(root.Left, p, q);
        }
        else if (p.Val > root.Val && q.Val > root.Val)
        {
            return LowestCommonAncestor(root.Right, p, q);
        }
        else
        {
            return root;
        }
    }
}
