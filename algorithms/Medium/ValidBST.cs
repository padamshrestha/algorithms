using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x)
    {
      val = x;
    }
  }

  public class ValidBST
  {
    private List<int> values;

    public ValidBST()
    {
      values = new List<int>();
    }

    public bool IsValid(TreeNode root)
    {
      if (root != null)
      {
        if (!IsValid(root.left)) return false;

        if (values.Count > 0 && values[values.Count - 1] >= root.val)
        {
          return false;
        }
        values.Add(root.val);

        if (!IsValid(root.right)) return false;
      }

      return true;
    }
  }
}
