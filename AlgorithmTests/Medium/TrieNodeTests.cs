using Algorithms.Medium;
using Xunit;

namespace AlgorithmTests.Medium
{
  public class TrieNodeTests
  {
    [Fact]
    public void TestTrie()
    {
      Trie trie = new Trie();
      trie.Insert("apple");

      Assert.True(trie.Search("apple"));
      Assert.False(trie.Search("app"));
      Assert.True(trie.StartsWith("app"));

      trie.Insert("app");
      Assert.True(trie.Search("app"));
    }
  }
}
