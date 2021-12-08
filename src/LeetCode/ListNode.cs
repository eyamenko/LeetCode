namespace LeetCode;

/// <summary>
/// Singly linked list node.
/// </summary>
public class ListNode
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ListNode"/> class.
    /// </summary>
    /// <param name="nodes">Node values.</param>
    public ListNode(params int[] nodes)
    {
        if (nodes.Length == 0)
        {
            throw new ArgumentException("Nodes cannot be empty", nameof(nodes));
        }

        this.Val = nodes[0];

        if (nodes.Length > 1)
        {
            this.Next = new ListNode(nodes[1..]);
        }
    }

    /// <summary>
    /// Gets value.
    /// </summary>
    public int Val { get; }

    /// <summary>
    /// Gets or sets the next node.
    /// </summary>
    public ListNode? Next { get; set; }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is not ListNode other)
        {
            return false;
        }

        if (this == other)
        {
            return true;
        }

        if (this.Val != other.Val)
        {
            return false;
        }

        if (this.Next is not null)
        {
            return this.Next.Equals(other.Next);
        }

        return other.Next is null;
    }

    /// <inheritdoc/>
    public override int GetHashCode() => (this.Val, this.Next).GetHashCode();
}
