namespace LeetCode;

using System.Globalization;

/// <summary>
/// <see href="https://leetcode.com/problems/serialize-and-deserialize-binary-tree/">Serialize and Deserialize Binary Tree</see>.
/// </summary>
public class Problem44
{
    /// <summary>
    /// Encodes a tree to a single string.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="root">Binary tree to serialize.</param>
    /// <returns>Serialized binary tree.</returns>
    public string Serialize(TreeNode? root)
    {
        if (root == null)
        {
            return string.Empty;
        }

        return $"{root.Val},{this.Serialize(root.Left)},{this.Serialize(root.Right)}";
    }

    /// <summary>
    /// Decodes your encoded data to tree.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="data">Serialized binary tree.</param>
    /// <returns>Deserialized binary tree.</returns>
    public TreeNode? Deserialize(string data)
    {
        if (string.IsNullOrEmpty(data))
        {
            return null;
        }

        var queue = new Queue<int?>();

        for (int left = 0, right = 0; right < data.Length; right++)
        {
            if (data[right] == ',')
            {
                if (left < right)
                {
                    queue.Enqueue(int.Parse(data[left..right], CultureInfo.CurrentCulture));
                }
                else
                {
                    queue.Enqueue(null);
                }

                left = right + 1;
            }
        }

        return Traverse(queue);
    }

    private static TreeNode? Traverse(Queue<int?> queue)
    {
        if (!queue.TryDequeue(out var num) || num == null)
        {
            return null;
        }

        return new TreeNode(num)
        {
            Left = Traverse(queue),
            Right = Traverse(queue),
        };
    }
}
