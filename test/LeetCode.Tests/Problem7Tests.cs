namespace LeetCode.Tests;

using Xunit;

public class Problem7Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { new ListNode(1, 4, 5), new ListNode(1, 3, 4), new ListNode(2, 6) }, new ListNode(1, 1, 2, 3, 4, 4, 5, 6) },
        new object[] { Array.Empty<ListNode>() },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void MergeKLists_should_merge_linked_lists(ListNode[] lists, ListNode? expected = null)
    {
        var actual = Problem7.MergeKLists(lists);

        Assert.Equal(expected, actual);
    }
}
