namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/linked-list-cycle/">Linked List Cycle</see>.
/// </summary>
public static class Problem28
{
    /// <summary>
    /// Given head, the head of a linked list, determine if the linked list has a cycle in it.
    /// Return true if there is a cycle in the linked list. Otherwise, return false.
    /// Time complexity: O(n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="head">Linked list's head.</param>
    /// <returns>True, if there is a cycle in the linked list.</returns>
    public static bool HasCycle(ListNode? head)
    {
        if (head == null)
        {
            return false;
        }

        for (ListNode slow = head, fast = head; fast.Next?.Next != null && slow.Next != null;)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }
}
