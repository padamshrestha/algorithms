using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class TwoSumTests
  {
    [Fact]
    public void EvaluateTrue1()
    {
      Assert.Equal(new int[] { 0, 1 }, TwoSum.Evaluate(new int[] { 2, 7, 11, 15 }, 9));
    }

    [Fact]
    public void EvaluateTrue2()
    {
      Assert.Equal(new int[] { 1, 2 }, TwoSum.Evaluate(new int[] { 3, 2, 4 }, 6));
    }
  }
}