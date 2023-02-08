using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class CourseScheduleTOWithDFS
  {
    public static bool CanFinish(int numCourses, int[,] prerequisites)
    {

      Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
      Dictionary<int, int> visited = new Dictionary<int, int>();

      for (var i = 0; i < prerequisites.GetLength(0); i++)
      {
        var course = prerequisites[i, 0];
        var prerequisite = prerequisites[i, 1];
        if (!graph.ContainsKey(course))
        {
          graph.Add(course, new List<int>());
        }
        graph[course].Add(prerequisite);
      }

      for (var i = 0; i < prerequisites.GetLength(0); i++)
      {
        var course = prerequisites[i, 0];
        if (DFS(course, graph, visited)) return false;
      }

      return true;
    }

    private static bool DFS(int i, Dictionary<int, List<int>> graph, Dictionary<int, int> visited)
    {
      // 0 UNKNOWN/Not in Dictionary
      // 1 VISITING/PARTIAL
      // 2 COMPLETE
      if (visited.ContainsKey(i) && visited[i] == 1) return true;
      if (visited.ContainsKey(i) && visited[i] == 2) return false;

      visited[i] = 1;

      foreach (var dep in graph[i])
      {
        if (graph.ContainsKey(dep) && DFS(dep, graph, visited)) return true;
      }

      visited[i] = 2;

      return false;
    }
  }
}
