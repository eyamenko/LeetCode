namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/top-k-frequent-elements/">Top K Frequent Elements</see>.
/// </summary>
public static class Problem47
{
    /// <summary>
    /// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
    /// Time complexity: O(k log n).
    /// Space complexity: O(n).
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

        var heap = new int[dict.Keys.Count];
        var heapSize = 0;
        var comparer = Comparer<int>.Create((a, b) => dict[a].CompareTo(dict[b]));

        foreach (var num in dict.Keys)
        {
            heap[heapSize] = num;
            HeapifyUp(heap, heapSize, comparer);
            heapSize++;
        }

        var result = new int[k];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = heap[0];
            heapSize--;
            heap[0] = heap[heapSize];
            HeapifyDown(heap, 0, heapSize, comparer);
        }

        return result;
    }

    private static void HeapifyDown<T>(T[] arr, int i, int size, IComparer<T> comparer)
    {
        var highest = i;

        while (highest < size / 2)
        {
            var (left, right) = ((2 * i) + 1, (2 * i) + 2);

            if (left < size && comparer.Compare(arr[left], arr[i]) > 0)
            {
                highest = left;
            }

            if (right < size && comparer.Compare(arr[right], arr[highest]) > 0)
            {
                highest = right;
            }

            if (highest == i)
            {
                break;
            }

            (arr[i], arr[highest], i) = (arr[highest], arr[i], highest);
        }
    }

    private static void HeapifyUp<T>(T[] arr, int i, IComparer<T> comparer)
    {
        for (var parent = (i - 1) / 2; comparer.Compare(arr[parent], arr[i]) < 0; i = parent, parent = (i - 1) / 2)
        {
            (arr[i], arr[parent]) = (arr[parent], arr[i]);
        }
    }
}
