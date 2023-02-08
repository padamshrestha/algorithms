using System.Collections.Generic;
using Algorithm.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class BuildOrder2Test
  {
    [Fact]
    public void TestName()
    {
      var builder = new BuildOrder2();
      var stack = new Stack<string>();
      stack.Push("c");
      stack.Push("d");
      stack.Push("a");
      stack.Push("b");
      stack.Push("e");
      stack.Push("f");
      // var stack = new Stack<string> { "f", "e", "a", "b", "d", "c" };
      var dep = new string[][] { new string[] { "a", "d" }, new string[] { "f", "b" }, new string[] { "b", "d" }, new string[] { "f", "a" }, new string[] { "d", "c" } };
      Assert.Equal(stack, builder.FindBuildOrder(new string[] { "a", "b", "c", "d", "e", "f" }, dep));
    }
  }
}
