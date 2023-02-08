using Algorithm.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class SearchInRotatedSortedDupArrayIITests
  {
    [Fact]
    public void TestName()
    {
      Assert.True(SearchInRotatedSortedDupArrayII.Search(new int[] { 2, 5, 6, 0, 0, 1, 2 }, 0));
      Assert.False(SearchInRotatedSortedDupArrayII.Search(new int[] { 2, 5, 6, 0, 0, 1, 2 }, 3));
    }
  }
}
