using System;
using System.Collections.Generic;

namespace Algorithms.Simple
{
  public class MinCostClimbingStairs
  {
    public static int Find(int[] vs)
    {
      var dp = new int[vs.Length];
      dp[0] = vs[0];
      dp[1] = vs[1];

      for (var i = 2; i < vs.Length; i++)
      {
        dp[i] = vs[i] + Math.Min(dp[i - 1], dp[i - 2]);
      }

      return Math.Min(dp[vs.Length - 1], dp[vs.Length - 2]);
    }
  }
}
