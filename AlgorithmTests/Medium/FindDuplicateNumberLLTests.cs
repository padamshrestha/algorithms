using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class FindDuplicateNumberLLTests
  {
    [Fact]
    public void TestLL()
    {
      Assert.Equal(2, FindDuplicateNumberLL.Find(new int[] { 1, 3, 4, 2, 2 }));
      Assert.Equal(3, FindDuplicateNumberLL.Find(new int[] { 3, 1, 3, 4, 2 }));
      Assert.Equal(1, FindDuplicateNumberLL.Find(new int[] { 1, 1 }));
      Assert.Equal(1, FindDuplicateNumberLL.Find(new int[] { 1, 1, 2 }));
    }
  }
}
