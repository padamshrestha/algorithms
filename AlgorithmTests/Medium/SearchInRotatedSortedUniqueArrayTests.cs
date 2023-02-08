using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class SearchInRotatedSortedUniqueArrayTests
  {
    [Fact]
    public void TestName()
    {
      Assert.Equal(4, SearchInRotatedSortedUniqueArray.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
      Assert.Equal(-1, SearchInRotatedSortedUniqueArray.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3));
      Assert.Equal(-1, SearchInRotatedSortedUniqueArray.Search(new int[] { 1 }, 0));
    }
  }
}
