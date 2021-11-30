namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/remove-nth-node-from-end-of-list/">Remove Nth Node From End of List</see>.
/// </summary>
public static class Problem5
{
    /// <summary>
    /// Given the head of a linked list, remove the nth node from the end of the list and return its head.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="head">Linked list's head.</param>
    /// <param name="n">Nth node to remove.</param>
    /// <returns>New linked list's head.</returns>
    public static ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var (count, next) = (1, head.Next);

        while (next != null)
        {
            (count, next) = (count + 1, next.Next);
        }

        if (count < n)
        {
            return null;
        }

        var (previous, current) = (default(ListNode), head);

        for (var i = count - n; i > 0 && current.Next != null; i--)
        {
            (previous, current) = (current, current.Next);
        }

        if (previous == null)
        {
            return current.Next;
        }

        previous.Next = current.Next;

        return head;
    }
}
