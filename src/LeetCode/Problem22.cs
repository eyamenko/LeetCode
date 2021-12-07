namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/">Construct Binary Tree from Preorder and Inorder Traversal</see>.
/// </summary>
public static class Problem22
{
    /// <summary>
    /// Given two integer arrays preorder and inorder where preorder is the preorder traversal of a binary tree and inorder is the inorder traversal of the same tree,
    /// construct and return the binary tree.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="preorder">Preorder array.</param>
    /// <param name="inorder">Inorder array.</param>
    /// <returns>Constructed binary tree.</returns>
    public static TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        var inorderDict = new Dictionary<int, int>(inorder.Length);

        for (var i = 0; i < inorder.Length; i++)
        {
            inorderDict.Add(inorder[i], i);
        }

        return BuildTree(preorder, 0, inorderDict, 0, inorder.Length - 1);
    }

    private static TreeNode? BuildTree(int[] preorder, int preorderIndex, Dictionary<int, int> inorderDict, int low, int high)
    {
        if (low > high)
        {
            return null;
        }

        var preorderElement = preorder[preorderIndex];
        var inorderIndex = inorderDict[preorderElement];
        var leftPreorderIndex = preorderIndex + 1;
        var rightPreorderIndex = leftPreorderIndex + inorderIndex - low;

        return new TreeNode(preorderElement)
        {
            Left = BuildTree(preorder, leftPreorderIndex, inorderDict, low, inorderIndex - 1),
            Right = BuildTree(preorder, rightPreorderIndex, inorderDict, inorderIndex + 1, high),
        };
    }
}
