using System.Collections.Generic;
using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class PermutationTests
  {
    [Fact]
    public void PermuteTest1()
    {
      Assert.Equal(new List<List<int>> {
        new List<int> { 1, 2, 3 },
        new List<int> { 1, 3, 2 },
        new List<int> { 2, 1, 3 },
        new List<int> { 2, 3, 1 },
        new List<int> { 3, 1, 2 },
        new List<int> { 3, 2, 1 } }, Permutation.Permute(new List<int> { 1, 2, 3 }));
    }


    [Fact]
    public void PermuteTest2()
    {
      Assert.Equal(new List<List<int>> {
        new List<int> { 0, 1 },
        new List<int> { 1, 0 } }, Permutation.Permute(new List<int> { 0, 1 }));
    }


    [Fact]
    public void PermuteTest3()
    {
      Assert.Equal(new List<List<int>> {
        new List<int> { 1 } }, Permutation.Permute(new List<int> { 1 }));
    }
  }
}
