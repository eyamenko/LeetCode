namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/top-k-frequent-elements/">Top K Frequent Elements</see>.
/// </summary>
public static class Problem47
{
    /// <summary>
    /// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
    /// Time complexity: O(k log d).
    /// Space complexity: O(d).
    /// </summary>
    /// <param name="nums">Array to traverse.</param>
    /// <param name="k">k most frequent elements to return.</param>
    /// <returns>k most frequent elements.</returns>
    public static int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict.Add(num, 1);
            }
        }

        var heap = new BinaryHeap<int>(Comparer<int>.Create((a, b) => dict[a].CompareTo(dict[b])), dict.Keys.Count);

        foreach (var num in dict.Keys)
        {
            heap.Enqueue(num);
        }

        var result = new int[k];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = heap.Dequeue();
        }

        return result;
    }
}
