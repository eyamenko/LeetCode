namespace LeetCode.Tests;

using Xunit;

public class Problem5Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { new[] { 1, 2, 3, 4, 5 }, 2, new[] { 1, 2, 3, 5 } },
        new object[] { new[] { 1 }, 1, Array.Empty<int>() },
        new object[] { new[] { 1, 2 }, 1, new[] { 1 } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void RemoveNthFromEnd_should_remove_nth_element_from_end(int[] nodes, int n, int[] expected)
    {
        var actual = Problem5.RemoveNthFromEnd(new ListNode(nodes), n);

        if (expected.Length == 0)
        {
            Assert.Null(actual);
        }
        else
        {
            Assert.Equal(new ListNode(expected), actual);
        }
    }
}
