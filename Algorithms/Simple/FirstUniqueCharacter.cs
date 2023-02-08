using System;
using System.Collections.Generic;

namespace Algorithms.Simple
{
  public class FirstUniqueCharacter
  {
    public static int GetIndex(string stringInput)
    {
      var charCheckMap = new Dictionary<char, int>();
      var foundIndex = -1;

      for (var i = 0; i < stringInput.Length; i++)
      {
        charCheckMap[stringInput[i]] = charCheckMap.ContainsKey(stringInput[i]) ? -1 : i;
      }

      foreach (var kvp in charCheckMap)
      {
        if (kvp.Value > -1)
        {
          foundIndex = kvp.Value;
          break;
        }
      }

      return foundIndex;
    }
  }
}
