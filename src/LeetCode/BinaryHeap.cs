namespace LeetCode;

/// <summary>
/// Binary heap.
/// </summary>
/// <typeparam name="T">Item's type.</typeparam>
public class BinaryHeap<T>
{
    private readonly IComparer<T> comparer;
    private T[] heap;

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryHeap{T}"/> class.
    /// </summary>
    /// <param name="comparer">Comparer to use to compare items.</param>
    /// <param name="capacity">Initial capacity.</param>
    public BinaryHeap(IComparer<T> comparer, int capacity = 100)
    {
        this.comparer = comparer;
        this.heap = new T[capacity];
    }

    /// <summary>
    /// Gets count.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Peeks the top item.
    /// </summary>
    /// <returns>Top item.</returns>
    public T Peek()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        return this.heap[0];
    }

    /// <summary>
    /// Enqueues the item.
    /// </summary>
    /// <param name="item">Item to enqueue.</param>
    public void Enqueue(T item)
    {
        this.EnsureCapacity();
        this.heap[this.Count] = item;
        this.HeapifyUp(this.Count);
        this.Count++;
    }

    /// <summary>
    /// Dequeues the item.
    /// </summary>
    /// <returns>Dequeued item.</returns>
    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        this.Count--;
        var item = this.heap[0];
        this.heap[0] = this.heap[this.Count];
        this.HeapifyDown(0);

        return item;
    }

    private void EnsureCapacity()
    {
        if (this.Count >= this.heap.Length)
        {
            var expandedHeap = new T[2 * this.Count];
            Array.Copy(this.heap, expandedHeap, this.Count);
            this.heap = expandedHeap;
        }
    }

    private void HeapifyDown(int i)
    {
        var highest = i;

        while (highest < this.Count / 2)
        {
            var (left, right) = ((2 * i) + 1, (2 * i) + 2);

            if (left < this.Count && this.comparer.Compare(this.heap[left], this.heap[i]) > 0)
            {
                highest = left;
            }

            if (right < this.Count && this.comparer.Compare(this.heap[right], this.heap[highest]) > 0)
            {
                highest = right;
            }

            if (highest == i)
            {
                break;
            }

            (this.heap[i], this.heap[highest], i) = (this.heap[highest], this.heap[i], highest);
        }
    }

    private void HeapifyUp(int i)
    {
        for (var parent = (i - 1) / 2; this.comparer.Compare(this.heap[parent], this.heap[i]) < 0; i = parent, parent = (i - 1) / 2)
        {
            (this.heap[i], this.heap[parent]) = (this.heap[parent], this.heap[i]);
        }
    }
}
