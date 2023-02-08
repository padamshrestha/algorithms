using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class AnagramTests
  {
    [Fact]
    public void ValidAnagram()
    {
      Assert.True(Anagram.IsAnagram("anagram", "nagaram"));
    }

    [Fact]
    public void InvalidAnagram()
    {
      Assert.False(Anagram.IsAnagram("car", "jar"));
    }
  }
}