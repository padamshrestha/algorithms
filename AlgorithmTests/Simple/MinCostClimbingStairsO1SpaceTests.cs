using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class MinCostClimbingStairsO1SpaceTests
  {
    [Fact]
    public void MinCostTest1()
    {
      Assert.Equal(15, MinCostClimbingStairsO1Space.Find(new int[] { 10, 15, 20 }));
    }

    [Fact]
    public void MinCostTest2()
    {
      Assert.Equal(6, MinCostClimbingStairsO1Space.Find(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
    }
  }
}
