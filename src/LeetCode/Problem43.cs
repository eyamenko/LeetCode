namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/find-median-from-data-stream/">Find Median from Data Stream</see>.
/// </summary>
public class Problem43
{
    private readonly PriorityQueue<int, int> minHeap;
    private readonly PriorityQueue<int, int> maxHeap;

    /// <summary>
    /// Initializes a new instance of the <see cref="Problem43"/> class.
    /// </summary>
    public Problem43()
    {
        this.minHeap = new PriorityQueue<int, int>(25000, new MinHeapComparer());
        this.maxHeap = new PriorityQueue<int, int>(25000, new MaxHeapComparer());
    }

    /// <summary>
    /// Adds the integer `num` from the data stream to the data structure.
    /// Time complexity: O(log n).
    /// Space complexity: O(1).
    /// </summary>
    /// <param name="num">Number to add.</param>
    public void AddNum(int num)
    {
        if ((this.minHeap.Count < this.maxHeap.Count && this.maxHeap.Peek() <= num)
        || (this.minHeap.Count > this.maxHeap.Count && this.minHeap.Peek() < num)
        || (this.minHeap.Count == this.maxHeap.Count && (this.minHeap.Count == 0 || this.minHeap.Peek() < num)))
        {
            if (this.minHeap.Count > this.maxHeap.Count)
            {
                var maxHeapNum = this.minHeap.EnqueueDequeue(num, num);

                this.maxHeap.Enqueue(maxHeapNum, maxHeapNum);
            }
            else
            {
                this.minHeap.Enqueue(num, num);
            }
        }
        else
        {
            if (this.maxHeap.Count > this.minHeap.Count)
            {
                var minHeapNum = this.maxHeap.EnqueueDequeue(num, num);

                this.minHeap.Enqueue(minHeapNum, minHeapNum);
            }
            else
            {
                this.maxHeap.Enqueue(num, num);
            }
        }
    }

    /// <summary>
    /// Returns the median of all elements so far. Answers within 10-5 of the actual answer will be accepted.
    /// Time complexity: O(1).
    /// Space complexity: O(1).
    /// </summary>
    /// <returns>Median from data stream.</returns>
    public double FindMedian()
    {
        if (this.minHeap.Count > this.maxHeap.Count)
        {
            return this.minHeap.Peek();
        }
        else if (this.maxHeap.Count > this.minHeap.Count)
        {
            return this.maxHeap.Peek();
        }
        else
        {
            return (this.minHeap.Peek() + this.maxHeap.Peek()) / 2.0;
        }
    }

    private class MinHeapComparer : IComparer<int>
    {
        public int Compare(int x, int y) => x.CompareTo(y);
    }

    private class MaxHeapComparer : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
