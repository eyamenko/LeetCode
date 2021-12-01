namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/merge-k-sorted-lists/">Merge k Sorted Lists</see>.
/// </summary>
public static class Problem7
{
    /// <summary>
    /// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
    /// Time complexity: O(n log k).
    /// Space complexity: O(k).
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
        if (right == null || left == null)
        {
            return right ?? left;
        }

        ListNode head, current;

        if (left.Val < right.Val)
        {
            (head, current, left) = (left, left, left.Next);
        }
        else
        {
            (head, current, right) = (right, right, right.Next);
        }

        while (left != null || right != null)
        {
            if (left == null || right == null)
            {
                current.Next = left ?? right;
                break;
            }
            else if (left.Val < right.Val)
            {
                (current, current.Next, left) = (left, left, left.Next);
            }
            else
            {
                (current, current.Next, right) = (right, right, right.Next);
            }
        }

        return head;
    }
}
