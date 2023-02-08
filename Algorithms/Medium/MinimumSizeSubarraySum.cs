using System;
using System.Linq;

namespace Algorithms.Medium
{
  public class MinimumSizeSubarraySum
  {
    public static int FindArrayLength(int[] nums, int target)
    {
      var l = 0;
      var total = 0;
      var ans = nums.Length + 1;

      foreach (var r in Enumerable.Range(0, nums.Length))
      {
        total += nums[r];
        while (total >= target)
        {
          ans = Math.Min(ans, r - l + 1);
          total -= nums[l];
          l++;
        }
      }

      return ans == nums.Length + 1 ? 0 : ans;
    }
  }
}
