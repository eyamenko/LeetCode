namespace LeetCode.Tests;

using Xunit;

public class Problem54Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new ListNode(2, 4, 3), new ListNode(5, 6, 4), new ListNode(7, 0, 8) },
        new object[] { new ListNode(0), new ListNode(0), new ListNode(0) },
        new object[] { new ListNode(9, 9, 9, 9, 9, 9, 9), new ListNode(9, 9, 9, 9), new ListNode(8, 9, 9, 9, 0, 0, 0, 1) },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void AddTwoNumbers_should_construct_linked_list_of_sum(ListNode l1, ListNode l2, ListNode expected)
    {
        var actual = Problem54.AddTwoNumbers(l1, l2);

        Assert.Equal(expected, actual);
    }
}
