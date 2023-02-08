using System;
using System.Collections.Generic;

namespace Algorithms.Simple
{
  public class BinarySearch
  {
    public static int Do(int[] nums, int target)
    {
      int left = 0;
      int right = nums.Length - 1;

      while (left <= right)
      {
        var midIndex = left + ((right - left) / 2);
        if (nums[midIndex] == target) return midIndex;

        if (target < nums[midIndex])
        {
          right = midIndex - 1;
        }
        else
        {
          left = midIndex + 1;
        }
      }

      return -1;
    }
  }
}
