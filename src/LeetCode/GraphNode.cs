namespace LeetCode;

/// <summary>
/// Graph node.
/// </summary>
public class GraphNode
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GraphNode"/> class.
    /// </summary>
    /// <param name="val">Node value.</param>
    public GraphNode(int val)
    {
        this.Val = val;
        this.Neighbors = new List<GraphNode>();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GraphNode"/> class.
    /// </summary>
    /// <param name="neighbors">Node neighbors.</param>
    public GraphNode(params int[][] neighbors)
    : this(neighbors, new Dictionary<int, GraphNode>(), 1)
    {
    }

    private GraphNode(int[][] neighbors, IDictionary<int, GraphNode> dict, int val)
    : this(val)
    {
        dict.Add(val, this);

        for (int i = 0, nodeIdx = val - 1; neighbors.Length > 0 && i < neighbors[nodeIdx].Length; i++)
        {
            if (dict.ContainsKey(neighbors[nodeIdx][i]))
            {
                this.Neighbors.Add(dict[neighbors[nodeIdx][i]]);
            }
            else
            {
                this.Neighbors.Add(new GraphNode(neighbors, dict, neighbors[nodeIdx][i]));
            }
        }
    }

    /// <summary>
    /// Gets value.
    /// </summary>
    public int Val { get; }

    /// <summary>
    /// Gets neighbors.
    /// </summary>
    public IList<GraphNode> Neighbors { get; }

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }

        if (obj is not GraphNode other)
        {
            return false;
        }

        return this.Equals(other, new HashSet<GraphNode>());
    }

    /// <inheritdoc/>
    public override int GetHashCode() => this.Val.GetHashCode();

    private bool Equals(GraphNode other, ISet<GraphNode> visited)
    {
        if (!visited.Add(other))
        {
            return true;
        }

        if (this == other)
        {
            return true;
        }

        if (this.Val != other.Val)
        {
            return false;
        }

        if (this.Neighbors.Count != other.Neighbors.Count)
        {
            return false;
        }

        for (var i = 0; i < this.Neighbors.Count; i++)
        {
            if (!this.Neighbors[i].Equals(other.Neighbors[i], visited))
            {
                return false;
            }
        }

        return true;
    }
}
