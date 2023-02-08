using System;
using System.Collections.Generic;
namespace Algorithms.Medium
{
  public class TrieNode
  {
    public Dictionary<char, TrieNode> children;
    public bool endOfWord;
    public TrieNode()
    {
      children = new Dictionary<char, TrieNode>();
      endOfWord = false;
    }

  }
  public class Trie
  {
    public TrieNode root { get; private set; }
    public Trie()
    {
      root = new TrieNode();
    }

    public void Insert(string v)
    {
      var current = root;

      for (var i = 0; i < v.Length; i++)
      {
        if (!current.children.ContainsKey(v[i]))
        {
          current.children.Add(v[i], new TrieNode());
        }
        current = current.children[v[i]];
      }

      current.endOfWord = true;
    }

    public virtual bool Search(string v, bool isStartsWith = false)
    {
      var current = root;
      for (var i = 0; i < v.Length; i++)
      {
        if (!current.children.ContainsKey(v[i])) return false;

        current = current.children[v[i]];
      }

      return isStartsWith ? true : current.endOfWord;
    }

    public bool StartsWith(string v)
    {
      return Search(v, true);
    }
  }
}
