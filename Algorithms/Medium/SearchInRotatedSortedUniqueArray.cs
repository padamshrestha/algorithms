using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class SearchInRotatedSortedUniqueArray
  {
    public static int Search(int[] nums, int target)
    {
      int left = 0, right = nums.Length - 1;
      while (left <= right)
      {
        var mid = left + (right - left) / 2;
        if (nums[mid] == target) return mid;

        if (nums[left] <= nums[mid])
        {
          if (nums[left] <= target && target < nums[mid])
          {
            right = mid - 1;
          }
          else
          {
            left = mid + 1;
          }
        }
        else
        {
          if (nums[mid] < target && target <= nums[right])
          {
            left = mid + 1;
          }
          else
          {
            right = mid - 1;
          }
        }

      }

      return -1;
    }
  }
}
