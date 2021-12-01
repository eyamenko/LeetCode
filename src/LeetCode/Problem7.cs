namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/merge-k-sorted-lists/">Merge k Sorted Lists</see>.
/// </summary>
public static class Problem7
{
    /// <summary>
    /// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
    /// Time complexity: O(n^2).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="lists">Array to traverse.</param>
    /// <returns>Merged linked list.</returns>
    public static ListNode? MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
        {
            return null;
        }

        var head = lists[0];

        for (var i = 1; i < lists.Length; i++)
        {
            var (left, right, current) = (head, lists[i], default(ListNode));

            while (left != null || right != null)
            {
                ListNode smallest;

                if (right == null || (left != null && left.Val < right.Val))
                {
                    (smallest, left) = (left!, left!.Next);
                }
                else
                {
                    (smallest, right) = (right, right.Next);
                }

                if (current == null)
                {
                    current = head = smallest;
                }
                else
                {
                    current = current.Next = smallest;
                }
            }
        }

        return head;
    }
}
