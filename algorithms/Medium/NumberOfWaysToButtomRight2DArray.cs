using System;
using System.Collections.Generic;

namespace Algorithms.Medium
{
  public class NumberOfWaysToButtomRight2DArray
  {
    public static int NumberOfWays(int row, int col)
    {
      return NumberOfWaysToBottom(row - 1, col - 1, new int[row, col]);
    }

    private static int NumberOfWaysToBottom(int row, int col, int[,] numOfWays)
    {
      if (row == 0 || col == 0) return 1;

      if (numOfWays[row, col] == 0)
      {
        var waysToTop = row == 0 ? 0 : NumberOfWaysToBottom(row - 1, col, numOfWays);
        var waysToLeft = col == 0 ? 0 : NumberOfWaysToBottom(row, col - 1, numOfWays);
        numOfWays[row, col] = waysToLeft + waysToTop;
      }

      return numOfWays[row, col];
    }
  }
}
