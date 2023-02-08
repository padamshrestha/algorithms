using System.Collections.Generic;
using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class LongestSubstringWithKUniqueCharTests
  {
    [Fact]
    public void TestName()
    {
      Assert.Equal(6, LongestSubstringWithKUniqueChar.Get("aabbcc", 3));
    }

    [Fact]
    public void TestName1()
    {
      Assert.Equal(4, LongestSubstringWithKUniqueChar.Get("aabbcc", 2));
    }

    [Fact]
    public void TestName2()
    {
      Assert.Equal(2, LongestSubstringWithKUniqueChar.Get("aabbcc", 1));
    }

    [Fact]
    public void TestName3()
    {
      Assert.Equal(3, LongestSubstringWithKUniqueChar.Get("eceba", 2));
    }
  }
}
