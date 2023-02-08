using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class Subsets
  {
    public static List<List<int>> Get(List<int> vs)
    {

      var ans = new List<List<int>>();
      // Might need to sort if the array is not sorted
      DFS(vs, ans, new List<int>(), 0);

      return ans;
    }

    private static void DFS(List<int> vs, List<List<int>> ans, List<int> curr, int startIndex)
    {
      ans.Add(new List<int>(curr));

      for (var i = startIndex; i < vs.Count; i++)
      {
        // Record all the subsets that include vs[i]
        curr.Add(vs[i]);
        DFS(vs, ans, curr, i + 1);

        // Remove from the present subset
        curr.RemoveAt(curr.Count - 1);
      }
    }
  }
}
