using System;
using System.Collections.Generic;

namespace AlgorithmTests.Medium
{
  public class Project
  {
    public List<Project> children = new List<Project>();
    public Dictionary<string, Project> projectMap = new Dictionary<string, Project>();
    public string name;
    private int dependencies = 0;
    public Project(string n)
    {
      name = n;
    }

    public void AddNeighbor(Project node)
    {
      if (!projectMap.ContainsKey(node.name))
      {
        children.Add(node);
        projectMap.Add(node.name, node);
        node.IncrementDependencies();
      }
    }

    private void IncrementDependencies() { dependencies++; }
    private void DecrementDependencies() { dependencies--; }
  }

  // TODO
  public class BuildOrder1
  {
    public List<Project> FindBuildOrder(string[] projects, string[,] dependencies)
    {
      // Graph graph = BuildGraph(projects, dependencies);
      // return OrderProjects(graph.GetNodes());

      return new List<Project>();
    }

  }
}
