namespace LeetCode.Tests;

using Xunit;

public class Problem59Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { 3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" } },
        new object[] { 1, new[] { "()" } },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void GenerateParenthesis_should_generate_all_combinations_of_well_formed_parentheses(int n, string[] expected)
    {
        var actual = Problem59.GenerateParenthesis(n);

        Assert.Equal(expected, actual);
    }
}
