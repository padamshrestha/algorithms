using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class CombinationSum
  {
    public static List<List<int>> Get(List<int> list, int target)
    {
      var ans = new List<List<int>>();
      // Might need to sort input if not sorted
      DFS(list, target, ans, new List<int>(), 0);

      return ans;
    }

    private static void DFS(List<int> list, int target, List<List<int>> ans, List<int> curr, int startIndex)
    {
      if (target == 0)
      {
        ans.Add(new List<int>(curr));
        return;
      }

      for (var i = startIndex; i < list.Count; i++)
      {
        if (list[i] > target) break;

        curr.Add(list[i]);
        DFS(list, target - list[i], ans, curr, i);

        curr.RemoveAt(curr.Count - 1);
      }
    }
  }
}
