namespace LeetCode.Tests;

using Xunit;

public class Problem28Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new ListNode(3, 2, 0, -4), 1, true },
        new object[] { new ListNode(1, 2), 0, true },
        new object[] { new ListNode(1), -1, false },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void HasCycle_should_determine_whether_linked_list_has_cycle(ListNode head, int pos, bool expected)
    {
        var last = head;
        ListNode? next = null;

        for (var i = 0; last.Next != null; i++)
        {
            if (i == pos)
            {
                next = last;
            }

            last = last.Next;
        }

        last.Next = next;

        var actual = Problem28.HasCycle(head);

        Assert.Equal(expected, actual);
    }
}
