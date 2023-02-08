// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// Example:
// Given nums = [2, 7, 11, 15], target = 9,
// Because nums[0] + nums[1] = 2 + 7 = 9,
// return [0, 1].

using System.Collections.Generic;

namespace Algorithms.Simple
{
  public class TwoSum
  {
    public static int[] Evaluate(int[] nums, int target)
    {
      var subtractedDictionary = new Dictionary<int, int>();
      var result = new int[2];

      for (var i = 0; i < nums.Length; i++)
      {
        var num = nums[i];
        if (!subtractedDictionary.ContainsKey(num))
        {
          subtractedDictionary[target - num] = i;
        }
        else
        {
          result = new int[] { subtractedDictionary[num], i };
        }
      }

      return result;
    }
  }
}
