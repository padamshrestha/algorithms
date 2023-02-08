using System.Collections.Generic;

namespace Algorithm.Medium
{

  public class Project2
  {
    public enum State { COMPLETE, PARTIAL, BLANK };
    public State state = State.BLANK;

    public void SetState(State s) { state = s; }
    public List<Project2> children = new List<Project2>();
    public Dictionary<string, Project2> projectMap = new Dictionary<string, Project2>();
    public string name;

    public Project2(string n)
    {
      name = n;
    }

    public void AddNeighbor(Project2 node)
    {
      if (!projectMap.ContainsKey(node.name))
      {
        children.Add(node);
        projectMap.Add(node.name, node);
      }
    }

  }

  public class Graph
  {
    public List<Project2> nodes = new List<Project2>();
    private Dictionary<string, Project2> map = new Dictionary<string, Project2>();

    public Project2 GetOrCreateNode(string name)
    {
      if (!map.ContainsKey(name))
      {
        var node = new Project2(name);
        nodes.Add(node);
        map.Add(name, node);
      }

      return map[name];
    }

    public void AddEdge(string startName, string endName)
    {
      var start = GetOrCreateNode(startName);
      var end = GetOrCreateNode(endName);
      start.AddNeighbor(end);
    }
  }


  public class BuildOrder2
  {
    public Stack<string> FindBuildOrder(string[] projects, string[][] dependencies)
    {
      Graph graph = BuildGraph(projects, dependencies);
      return OrderProjects(graph.nodes);
    }
    private Stack<string> OrderProjects(List<Project2> projects)
    {
      var stack = new Stack<string>();
      foreach (var project in projects)
      {
        if (project.state == Project2.State.BLANK)
        {
          if (!DoDFS(project, stack))
          {
            return null;
          }
        }
      }
      return stack;
    }

    private bool DoDFS(Project2 project, Stack<string> stack)
    {
      if (project.state == Project2.State.PARTIAL)
      {
        return false;
      }

      if (project.state == Project2.State.BLANK)
      {
        project.SetState(Project2.State.PARTIAL);
        var children = project.children;

        foreach (var child in children)
        {
          if (!DoDFS(child, stack))
          {
            return false;
          }
        }

        project.SetState(Project2.State.COMPLETE);
        stack.Push(project.name);
      }

      return true;
    }

    private Graph BuildGraph(string[] projects, string[][] dependencies)
    {
      var graph = new Graph();
      foreach (var project in projects)
      {
        graph.GetOrCreateNode(project);
      }

      foreach (var dependency in dependencies)
      {
        var first = dependency[0];
        var second = dependency[1];
        graph.AddEdge(first, second);
      }

      return graph;
    }
  }
}
