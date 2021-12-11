namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/kth-smallest-element-in-a-bst/">Kth Smallest Element in a BST</see>.
/// </summary>
public static class Problem39
{
    /// <summary>
    /// Given the root of a binary search tree, and an integer k, return the kth smallest value (1-indexed) of all the values of the nodes in the tree.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">Binary search tree to traverse.</param>
    /// <param name="k">Kth smallest element to return.</param>
    /// <returns>Kth smallest element.</returns>
    public static int KthSmallest(TreeNode root, int k)
    {
        var stack = new Stack<int>();

        if (Traverse(root, k, stack))
        {
            return stack.Peek();
        }

        return -1;
    }

    private static bool Traverse(TreeNode? node, int k, Stack<int> stack)
    {
        if (node == null)
        {
            return false;
        }

        if (Traverse(node.Left, k, stack))
        {
            return true;
        }

        stack.Push(node.Val);

        if (stack.Count == k)
        {
            return true;
        }

        return Traverse(node.Right, k, stack);
    }
}
