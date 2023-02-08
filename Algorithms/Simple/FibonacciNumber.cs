using System;
using System.Collections.Generic;

namespace Algorithms.Simple
{
  public class FibonacciNumber
  {
    public static int Recursive(int v)
    {
      if (v <= 1) return v;

      return Recursive(v - 1) + Recursive(v - 2);
    }

    public static int Dynamic(int v)
    {
      var fibCache = new Dictionary<int, int>();

      if (v <= 1) return v;

      if (fibCache.ContainsKey(v))
      {
        return fibCache[v];
      }
      else
      {
        fibCache.Add(v, Dynamic(v - 1) + Dynamic(v - 2));

      }

      return fibCache[v];
    }

    public static int Cache01Space(int v)
    {

      if (v <= 1) return v;

      var fb0 = 0;
      var fb1 = 1;

      for (var i = 2; i <= v; i++)
      {
        var fb = fb0 + fb1;
        fb0 = fb1;
        fb1 = fb;
      }

      return fb1;
    }
  }


}
