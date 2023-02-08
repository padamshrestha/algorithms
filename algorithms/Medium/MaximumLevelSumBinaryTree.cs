using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Medium
{
  public class MaximumLevelSumBinaryTree
  {
    public static int MaxLevelSum(TreeNode root)
    {
      if (root == null) return 0;

      var levels = new List<int>();
      var levelIndex = 0;

      var queue = new Queue<TreeNode>();
      queue.Enqueue(root);

      while (queue.Count > 0)
      {

        var queueCount = queue.Count;

        for (var i = 0; i < queueCount; i++)
        {

          var currentNode = queue.Dequeue();
          if (levels.Count > levelIndex)
          {
            levels[levelIndex] = levels[levelIndex] + currentNode.val;
          }
          else
          {
            levels.Add(currentNode.val);
          }

          if (currentNode.left != null) queue.Enqueue(currentNode.left);
          if (currentNode.right != null) queue.Enqueue(currentNode.right);
        }

        levelIndex++;
      }

      // + 1 since we started with level 0
      return levels.IndexOf(levels.Max()) + 1;
    }
  }
}
