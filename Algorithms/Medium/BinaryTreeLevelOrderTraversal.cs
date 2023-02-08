using System;
using System.Collections.Generic;
// using System.Linq;

namespace Algorithms.Medium
{
  /*
  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
  }
  */

  public class BinaryTreeLevelOrderTraversal
  {
    public static List<IList<int>> LevelOrder(TreeNode root)
    {
      var levels = new List<IList<int>>();
      if (root == null) return levels;

      var queue = new Queue<TreeNode>();
      queue.Enqueue(root);

      var levelIndex = 0;

      while (queue.Count > 0)
      {
        levels.Add(new List<int>());

        var queueCount = queue.Count;
        for (var i = 0; i < queueCount; i++)
        {
          TreeNode currentNode = queue.Dequeue();

          // levels.ElementAt(level).Add(currentNode.val);
          levels[levelIndex].Add(currentNode.val);

          if (currentNode.left != null) queue.Enqueue(currentNode.left);
          if (currentNode.right != null) queue.Enqueue(currentNode.right);
        }

        levelIndex++;
      }

      return levels;
    }
  }
}
