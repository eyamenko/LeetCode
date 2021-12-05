namespace LeetCode.Tests;

using Xunit;

public class Problem17Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "12", 2 },
        new object[] { "226", 3 },
        new object[] { "0", 0 },
        new object[] { "06", 0 },
        new object[] { "2110", 2 },
        new object[] { "2101", 1 },
        new object[] { "2011", 2 },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void NumDecodings_should_find_number_of_ways_to_decode_input_string(string s, int expected)
    {
        var actual = Problem17.NumDecodings(s);

        Assert.Equal(expected, actual);
    }
}
