using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class FindEventualSafeStates
  {

    enum State { UNKNOWN, VISITING, SAFE, UNSAFE };
    public int[] EventualSafeNodes(int[,] nums)
    {
      Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
      Dictionary<int, State> states = new Dictionary<int, State>();
      var ans = new List<int>();

      for (var i = 0; i < nums.Length; i++)
      {
        if (DFS(i, graph, states) == State.SAFE)
        {
          ans.Add(i);
        }
      }

      return ans.ToArray();
    }

    //TODO
    private State DFS(int i, Dictionary<int, List<int>> graph, Dictionary<int, State> states)
    {
      if (states.ContainsKey(i) && states[i] == State.VISITING) return states[i] = State.UNSAFE;

      return State.SAFE;
    }
  }
}
