using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class MinimumSizeSubarraySumTests
  {
    [Fact]
    public void FoundTest1()
    {
      Assert.Equal(2, MinimumSizeSubarraySum.FindArrayLength(new int[] { 2, 3, 1, 2, 4, 3 }, 7));
    }

    [Fact]
    public void FoundTest2()
    {
      Assert.Equal(1, MinimumSizeSubarraySum.FindArrayLength(new int[] { 1, 4, 4 }, 1));
    }

    [Fact]
    public void NotFoundTest1()
    {
      Assert.Equal(0, MinimumSizeSubarraySum.FindArrayLength(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 11));
    }
  }
}
