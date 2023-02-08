using System.Linq;
using System.Collections.Generic;
using System;

namespace Algorithms.Medium
{
  public class WordDictionary : Trie
  {

    public override bool Search(string v, bool isStartsWith = false)
    {
      return SearchRange(v, 0, root.children);
    }

    private bool SearchRange(string word, int start, Dictionary<char, TrieNode> children)
    {

      if (start >= word.Length)
      {
        return false;
      }

      if (children.ContainsKey(word[start]))
      {
        if (start == word.Length - 1)
        {
          return children[word[start]].endOfWord;
        }
        return SearchRange(word, start + 1, children[word[start]].children);
      }
      else
      {
        if (word[start] == '.')
        {
          foreach (var key in children.Keys)
          {
            if (start == word.Length - 1 && children.ContainsKey(key) && children[key].endOfWord)
            {
              return true;
            }
            if (SearchRange(word, start + 1, children[key].children))
            {
              return true;
            }
          }
          return false;
        }
        else
        {
          return false;
        }
      }
    }
  }
}
