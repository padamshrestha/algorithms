using System.Collections.Generic;
using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class SubsetsTest
  {
    [Fact]
    public void TestName()
    {
      Assert.Equal(new List<List<int>> {
          new List<int> {},
          new List<int> {1},
          new List<int> {1, 2},
          new List<int> {1, 2, 3},
          new List<int> {1, 3},
          new List<int> {2},
          new List<int> {2, 3},
          new List<int> {3}
          }, Subsets.Get(new List<int> { 1, 2, 3 }));
    }
  }
}
