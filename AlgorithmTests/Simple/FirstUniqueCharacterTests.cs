using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class FirstUniqueCharacterTests
  {
    [Fact]
    public void Test()
    {
      Assert.Equal(0, FirstUniqueCharacter.GetIndex("leetcode"));
      Assert.Equal(2, FirstUniqueCharacter.GetIndex("loveleetcode"));
    }
  }
}