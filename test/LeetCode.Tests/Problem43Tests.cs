namespace LeetCode.Tests;

using Xunit;

public class Problem43Tests
{
    [Fact]
    public void FindMedian_should_find_median_from_data_stream()
    {
        var medianFinder = new Problem43();

        medianFinder.AddNum(1);
        medianFinder.AddNum(2);

        Assert.Equal(1.5, medianFinder.FindMedian());

        medianFinder.AddNum(3);

        Assert.Equal(2.0, medianFinder.FindMedian());
    }
}
