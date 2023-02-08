using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Hard
{
  public static class SubarraysWithKDistinctIntegers
  {
    public static int SubarraysWithKDistinct(int[] A, int K)
    {
      return AtMostK(A, K) - AtMostK(A, K - 1);
    }

    public static int AtMostK(int[] A, int K)
    {
      var counter = new Dictionary<int, int>();
      var res = 0;
      var i = 0;
      foreach (var j in Enumerable.Range(0, A.Length))
      {
        if (counter.ContainsKey(A[j]) && counter[A[j]] == 0)
        {
          K -= 1;
        }
        counter[A[j]] = counter.ContainsKey(A[j]) ? counter[A[j]] + 1 : 0;
        while (K < 0)
        {
          counter[A[i]] -= 1;
          if (counter.ContainsKey(A[j]) && counter[A[i]] == 0)
          {
            K += 1;
          }
          i += 1;
        }
        res += j - i + 1;
      }
      return res;
    }
  }
}
