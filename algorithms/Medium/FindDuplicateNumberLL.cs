using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class FindDuplicateNumberLL
  {
    public static int Find(int[] vs)
    {
      int slow = 0, fast = 0;
      while (true)
      {
        slow = vs[slow];
        fast = vs[vs[fast]];
        if (slow == fast) break;
      }
      fast = 0;
      while (fast != slow)
      {
        slow = vs[slow];
        fast = vs[fast];
      }

      return slow;
    }
  }
}
