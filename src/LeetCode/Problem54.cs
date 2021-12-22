namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/add-two-numbers/">Add Two Numbers</see>.
/// </summary>
public static class Problem54
{
    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers.
    /// The digits are stored in reverse order, and each of their nodes contains a single digit.
    /// Add the two numbers and return the sum as a linked list.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="l1">List 1.</param>
    /// <param name="l2">List 2.</param>
    /// <returns>Sum as a linked list.</returns>
    public static ListNode? AddTwoNumbers(ListNode l1, ListNode l2) => Traverse(l1, l2, 0);

    private static ListNode? Traverse(ListNode? l1, ListNode? l2, int sum)
    {
        if (sum == 0 && (l1 == null || l2 == null))
        {
            return l1 ?? l2;
        }

        if (l1 != null)
        {
            sum += l1.Val;
        }

        if (l2 != null)
        {
            sum += l2.Val;
        }

        return new ListNode(sum % 10)
        {
            Next = Traverse(l1?.Next, l2?.Next, sum / 10),
        };
    }
}
