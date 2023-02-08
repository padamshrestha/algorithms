using System.Collections.Generic;
using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class CombinationSumTests
  {
    [Fact]
    public void TestName()
    {
      Assert.Equal(new List<List<int>> {
        new List<int> {2, 2, 3},
        new List<int> {7}
        }, CombinationSum.Get(new List<int> { 2, 3, 6, 7 }, 7));
    }
  }
}
