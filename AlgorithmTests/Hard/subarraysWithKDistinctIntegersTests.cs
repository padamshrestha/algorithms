using Algorithms.Hard;
using Xunit;

namespace AlgorithmTests.Hard
{
  public class subarraysWithKDistinctIntegersTests
  {
    [Fact]
    public void TestName()
    {
      Assert.Equal(7, SubarraysWithKDistinctIntegers.SubarraysWithKDistinct(new int[] { 1, 2, 3 }, 2));
    }
  }
}
