using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class Permutation
  {
    public static List<List<int>> Permute(List<int> vs)
    {
      var result = new List<List<int>>();
      bool[] visited = new bool[vs.Count];

      DFSPermute(vs, result, new List<int>(), visited);
      return result;
    }

    private static void DFSPermute(List<int> vs, List<List<int>> result, List<int> curr, bool[] visited)
    {
      if (curr.Count == vs.Count)
      {
        result.Add(new List<int>(curr));
        return;
      }
      for (var i = 0; i < vs.Count; i++)
      {
        if (visited[i] == false)
        {
          visited[i] = true;
          curr.Add(vs[i]);

          DFSPermute(vs, result, curr, visited);

          curr.RemoveAt(curr.Count - 1);
          visited[i] = false;
        }
      }
    }
  }
}
