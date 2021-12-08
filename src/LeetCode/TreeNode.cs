namespace LeetCode;

/// <summary>
/// Binary tree node.
/// </summary>
public class TreeNode
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TreeNode"/> class.
    /// </summary>
    /// <param name="nodes">Node values.</param>
    public TreeNode(params int?[] nodes)
    : this(nodes, 0)
    {
    }

    private TreeNode(int?[] nodes, int i)
    {
        if (nodes.Length == 0)
        {
            throw new ArgumentException("Nodes cannot be empty", nameof(nodes));
        }

        if (i >= nodes.Length)
        {
            throw new ArgumentException("Index is out of range", nameof(i));
        }

        this.Val = nodes[i] ?? throw new InvalidOperationException("Node value should be present");

        var leftIndex = (i * 2) + 1;
        var rightIndex = (i * 2) + 2;

        if (leftIndex < nodes.Length && nodes[leftIndex] != null)
        {
            this.Left = new TreeNode(nodes, leftIndex);
        }

        if (rightIndex < nodes.Length && nodes[rightIndex] != null)
        {
            this.Right = new TreeNode(nodes, rightIndex);
        }
    }

    /// <summary>
    /// Gets value.
    /// </summary>
    public int Val { get; }

    /// <summary>
    /// Gets or sets the left node.
    /// </summary>
    public TreeNode? Left { get; set; }

    /// <summary>
    /// Gets or sets the right node.
    /// </summary>
    public TreeNode? Right { get; set; }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is not TreeNode other)
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

        if (this.Left != null && this.Right != null)
        {
            return this.Left.Equals(other.Left) && this.Right.Equals(other.Right);
        }

        if (this.Left is not null)
        {
            return this.Left.Equals(other.Left);
        }

        if (this.Right is not null)
        {
            return this.Right.Equals(other.Right);
        }

        return other.Left == null && other.Right == null;
    }

    /// <inheritdoc/>
    public override int GetHashCode() => (this.Val, this.Left, this.Right).GetHashCode();
}
