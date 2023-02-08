using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class FindDuplicateNumberBS
  {
    public static int Find(int[] vs)
    {
      int l = 0, r = vs.Length - 1;

      while (l < r)
      {
        var pivot = (r - l) / 2 + l;

        var count = 0;
        foreach (var num in vs)
        {
          if (num <= pivot) count++;
        }

        if (count <= pivot)
        {
          l = pivot + 1;
        }
        else
        {
          r = pivot;
        }
      }

      return l;
    }
  }
}
