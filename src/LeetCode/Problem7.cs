namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/merge-k-sorted-lists/">Merge k Sorted Lists</see>.
/// </summary>
public static class Problem7
{
    /// <summary>
    /// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
    /// Time complexity: O(n k log k).
    /// Space complexity: O(n k).
    /// </summary>
    /// <param name="lists">Array to traverse.</param>
    /// <returns>Merged linked list.</returns>
    public static ListNode? MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
        {
            return null;
        }

        if (lists.Length == 1)
        {
            return lists[0];
        }

        var mid = lists.Length / 2;
        var left = lists[..mid];
        var right = lists[mid..];

        return Merge(MergeKLists(left), MergeKLists(right));
    }

    private static ListNode? Merge(ListNode? left, ListNode? right)
    {
        if (left == null || right == null)
        {
            return left ?? right;
        }

        if (left.Val <= right.Val)
        {
            left.Next = Merge(left.Next, right);

            return left;
        }
        else
        {
            right.Next = Merge(left, right.Next);

            return right;
        }
    }
}
