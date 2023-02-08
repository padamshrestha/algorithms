using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Medium;

namespace AlgorithmTests.Medium
{
  public class SerializeAndDeserializeBinaryTree
  {
    public string Serialize(TreeNode root)
    {
      if (root == null) return "";

      var sb = new StringBuilder();
      var nodeQueue = new Queue<TreeNode>();

      nodeQueue.Enqueue(root);

      while (nodeQueue.Count > 0)
      {
        var node = nodeQueue.Dequeue();
        if (node == null)
        {
          sb.Append('#');
        }
        else
        {
          sb.Append(node.val + " ");
          nodeQueue.Enqueue(node.left);
          nodeQueue.Enqueue(node.right);
        }
      }
      return sb.ToString();
    }

    public TreeNode DeSerialize(string data)
    {
      if (data.Equals('#')) return null;

      var nodes = data.Split(' ');
      TreeNode root = null;
      var nodeQueue = new Queue<TreeNode>();

      for (var i = 0; i < nodes.Length; i++)
      {
        if (nodeQueue.Count == 0)
        {
          root = new TreeNode(int.Parse(nodes[i]));
          nodeQueue.Enqueue(root);
        }
        else
        {
          TreeNode left = null;
          TreeNode right = null;
          if (!nodes[i].Equals('#'))
          {
            left = new TreeNode(Int32.Parse(nodes[i]));
            nodeQueue.Enqueue(left);
          }
          if (!nodes[i + 1].Equals('#'))
          {
            right = new TreeNode(Int32.Parse(nodes[i + 1]));
            nodeQueue.Enqueue(right);
          }

          TreeNode parent = nodeQueue.Peek();
          parent.left = left;
          parent.right = right;

          i++;
        }
      }

      return root;
    }
  }
}
