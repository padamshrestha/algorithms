using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Simple
{
  public class NumberToMoney
  {
    public static string Convert(double num)
    {
      const int ConversionBase = 1000;
      string[] powers = { "", "", "M", "B", "T" };
      bool isNegative = num < 0 ? true : false;

      int power = 0;

      while (Math.Abs(num) >= ConversionBase)
      {
        num = Math.Abs(num) / ConversionBase;
        power++;
      }

      return FormatValue(num, isNegative, powers[power]);
    }

    private static string FormatValue(double num, bool isNegative, string symbol)
    {
      const int FormatDigits = 1;
      var sb = new StringBuilder();
      if (isNegative) sb.Insert(0, "-");
      sb.Append(Math.Round(num, FormatDigits)).Append(symbol);
      return sb.ToString();
    }
  }
}
