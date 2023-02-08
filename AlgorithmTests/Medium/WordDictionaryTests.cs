using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class WordDictionaryTests
  {
    [Fact]
    public void TestName()
    {
      var wordDictionary = new WordDictionary();
      wordDictionary.Insert("bad");
      wordDictionary.Insert("dad");
      wordDictionary.Insert("mad");

      Assert.False(wordDictionary.Search("pad"));
      Assert.True(wordDictionary.Search("bad"));
      Assert.True(wordDictionary.Search(".ad"));
      Assert.True(wordDictionary.Search("b.."));
    }
  }
}
