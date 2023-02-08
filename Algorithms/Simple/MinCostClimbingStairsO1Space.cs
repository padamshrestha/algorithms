using System;
using System.Collections.Generic;

namespace Algorithms.Simple
{
  public class MinCostClimbingStairsO1Space
  {
    public static int Find(int[] vs)
    {
      int dp1 = 0;
      int dp2 = 0;

      for (var i = 2; i <= vs.Length; i++)
      {
        int dp = Math.Min(dp1 + vs[i - 1], dp2 + vs[i - 2]);
        dp2 = dp1;
        dp1 = dp;
      }

      return dp1;
    }
  }
}
