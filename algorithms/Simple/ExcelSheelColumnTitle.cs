using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Simple
{
  public class ExcelSheelColumnTitle
  {
    public static IEnumerable<char> Calculate(int v)
    {
      var colTitle = new StringBuilder();

      while (v != 0)
      {
        colTitle.Insert(0, (char)('A' + (v - 1) % 26));
        v = (v - 1) / 26;
      }

      return colTitle.ToString();
    }
  }
}
