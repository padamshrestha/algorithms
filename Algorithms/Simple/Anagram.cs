using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Simple
{
  public class Anagram
  {
    public static bool IsAnagram(string inputString1, string inputString2)
    {
      var charCountMap = new Dictionary<char, int>();

      foreach (var character in inputString1)
      {
        charCountMap[character] = charCountMap.ContainsKey(character) ? charCountMap[character] + 1 : 1;
      }

      foreach (var character in inputString2)
      {
        if (!charCountMap.ContainsKey(character)) return false;

        charCountMap[character] = charCountMap[character] - 1;
      }

      return charCountMap.Where(kvp => kvp.Value > 0).ToList().Count == 0;
    }
  }
}
