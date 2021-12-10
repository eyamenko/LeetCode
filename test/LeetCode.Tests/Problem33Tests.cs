namespace LeetCode.Tests;

using Xunit;

public class Problem33Tests
{
    public static readonly object[][] TestData = new[]
    {
        new object[] { 2, new[] { new[] { 1, 0 } }, true },
        new object[] { 2, new[] { new[] { 1, 0 }, new[] { 0, 1 } }, false },
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void CanFinish_should_determine_whether_all_courses_can_be_finished(int numCourses, int[][] prerequisites, bool expected)
    {
        var actual = Problem33.CanFinish(numCourses, prerequisites);

        Assert.Equal(expected, actual);
    }
}
