namespace LeetCode.Tests;

using Xunit;

public class Problem5Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new ListNode(1, 2, 3, 4, 5), 2, new ListNode(1, 2, 3, 5) },
        new object[] { new ListNode(1), 1 },
        new object[] { new ListNode(1, 2), 1, new ListNode(1) },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void RemoveNthFromEnd_should_remove_nth_element_from_end(ListNode head, int n, ListNode? expected = null)
    {
        var actual = Problem5.RemoveNthFromEnd(head, n);

        Assert.Equal(expected, actual);
    }
}
