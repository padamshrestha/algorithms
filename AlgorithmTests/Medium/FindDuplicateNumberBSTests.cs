using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class FindDuplicateNumberBSTests
  {
    [Fact]
    public void TestBS()
    {
      Assert.Equal(2, FindDuplicateNumberBS.Find(new int[] { 1, 3, 4, 2, 2 }));
      Assert.Equal(3, FindDuplicateNumberBS.Find(new int[] { 3, 1, 3, 4, 2 }));
      Assert.Equal(1, FindDuplicateNumberBS.Find(new int[] { 1, 1 }));
      Assert.Equal(1, FindDuplicateNumberBS.Find(new int[] { 1, 1, 2 }));
    }
  }
}
