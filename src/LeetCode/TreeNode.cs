namespace LeetCode;

/// <summary>
/// BST's node.
/// </summary>
public class TreeNode
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TreeNode"/> class.
    /// </summary>
    /// <param name="nodes">Node values.</param>
    public TreeNode(params int[] nodes)
    : this(nodes, 0)
    {
    }

    private TreeNode(int[] nodes, int i)
    {
        if (nodes.Length == 0)
        {
            throw new ArgumentException("Nodes cannot be empty", nameof(nodes));
        }

        this.Val = nodes[i];

        var leftIndex = (i * 2) + 1;
        var rightIndex = (i * 2) + 2;

        if (leftIndex < nodes.Length && nodes[leftIndex] != 0)
        {
            this.Left = new TreeNode(nodes, leftIndex);
        }

        if (rightIndex < nodes.Length && nodes[rightIndex] != 0)
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
}
