using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Medium
{
  public class LongestSubstringWithKUniqueChar
  {
    public static int Get(string vs, int target)
    {

      var l = 0;
      var ans = new List<string>();
      var max = 0;
      var uniqChars = new Dictionary<char, int>(); // total

      if (target == 0) return max;

      foreach (var r in Enumerable.Range(0, vs.Length))
      {
        uniqChars[vs[r]] = uniqChars.ContainsKey(vs[r]) ? uniqChars[vs[r]] + 1 : 1;

        while (uniqChars.Count > target)
        {
          var tempChar = vs[l];

          if (uniqChars[tempChar] == 1)
          {
            uniqChars.Remove(tempChar);

          }
          else
          {
            uniqChars[tempChar] = uniqChars[tempChar] - 1;
          }
          l++;
        }
        max = Math.Max(max, r - l + 1);
      }

      return max;
    }
  }
}
