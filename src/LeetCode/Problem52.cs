namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/subtree-of-another-tree/">Subtree of Another Tree</see>.
/// </summary>
public static class Problem52
{
    /// <summary>
    /// Given the roots of two binary trees root and subRoot, return true if there is a subtree of root with the same structure and node values of subRoot and false otherwise.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">Binary tree.</param>
    /// <param name="subRoot">Binary subtree.</param>
    /// <returns>True, if the binary tree contains the provided subtree.</returns>
    public static bool IsSubtree(TreeNode? root, TreeNode? subRoot)
    {
        if (root == null && subRoot == null)
        {
            return true;
        }

        if (root == null || subRoot == null)
        {
            return false;
        }

        return TraverseSubtree(root, subRoot) || IsSubtree(root.Left, subRoot) || IsSubtree(root.Right, subRoot);
    }

    private static bool TraverseSubtree(TreeNode? root, TreeNode? subRoot)
    {
        if (root == null && subRoot == null)
        {
            return true;
        }

        if (root == null || subRoot == null)
        {
            return false;
        }

        return root.Val == subRoot.Val && TraverseSubtree(root.Left, subRoot.Left) && TraverseSubtree(root.Right, subRoot.Right);
    }
}
