using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class CourseScheduleTOWithDFSTests
  {
    [Fact]
    public void LeetCodeTests()
    {
      Assert.True(CourseScheduleTOWithDFS.CanFinish(2, new int[,] { { 1, 0 } }));
      Assert.False(CourseScheduleTOWithDFS.CanFinish(2, new int[,] { { 1, 0 }, { 0, 1 } }));
    }

    [Fact]
    public void InvalidTest()
    {
      Assert.False(CourseScheduleTOWithDFS.CanFinish(7, new int[,] { { 1, 0 }, { 2, 6 }, { 1, 7 }, { 5, 1 }, { 6, 4 }, { 7, 0 }, { 0, 5 } }));
    }

    [Fact]
    public void ValidTest()
    {
      Assert.True(CourseScheduleTOWithDFS.CanFinish(7, new int[,] { { 1, 0 }, { 2, 6 }, { 1, 7 }, { 6, 4 }, { 7, 0 }, { 0, 5 } }));
    }
  }
}
