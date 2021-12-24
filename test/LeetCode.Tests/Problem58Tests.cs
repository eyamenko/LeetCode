namespace LeetCode.Tests;

using Xunit;

public class Problem58Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { "23", new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" } },
        new object[] { string.Empty, Array.Empty<string>() },
        new object[] { "2", new[] { "a", "b", "c" } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void LetterCombinations_should_find_all_possible_letter_combinations_that_number_could_represent(string digits, string[] expected)
    {
        var actual = Problem58.LetterCombinations(digits);

        Assert.Equal(expected, actual);
    }
}
