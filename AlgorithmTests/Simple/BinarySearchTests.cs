using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class BinarySearchTests
  {
    [Fact]
    public void ValidSearch()
    {
      Assert.Equal(4, BinarySearch.Do(new int[] { -1, 0, 3, 5, 9, 12 }, 9));
    }

    [Fact]
    public void InvalidSearch()
    {
      Assert.Equal(-1, BinarySearch.Do(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
    }
  }
}
