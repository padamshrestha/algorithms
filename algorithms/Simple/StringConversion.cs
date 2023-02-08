using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Simple
{
  public class StringConversion
  {
    public static string IntToString(int v)
    {
      bool isNegative = v < 0 ? true : false;

      var sb = new StringBuilder();
      do
      {
        var remainder = Math.Abs(v) % 10;
        sb.Insert(0, (char)('0' + remainder)); // remainder Math.Abs(v) % 10)
        v /= 10;  // times divisible
      } while (v != 0);

      if (isNegative) sb.Insert(0, '-');
      return sb.ToString();
    }

    public static int StringToInt(string v)
    {
      var result = 0;
      bool isNegative = v[0] == '-' ? true : false;

      for (var i = isNegative ? 1 : 0; i < v.Length; i++)
      {
        var digit = v[i] - '0';
        result = result * 10 + digit;
      }

      return isNegative ? -result : result;
    }

    public static string ConvertBase(string s, int b1, int b2)
    {
      bool isNegative = s[0] == '-' ? true : false;
      var numAsInt = 0;

      for (var i = isNegative ? 1 : 0; i < s.Length; i++)
      {
        numAsInt *= b1;
        numAsInt += Char.IsDigit(s[i]) ? s[i] - '0' : s[i] - 'A' + 10;
      }

      return (isNegative ? "-" : "") + (numAsInt == 0 ? "" : ConstructFromBase(numAsInt, b2));
    }

    private static string ConstructFromBase(int numAsInt, int b2)
    {
      return numAsInt == 0 ? "" : ConstructFromBase(numAsInt / b2, b2) + (char)(numAsInt % b2 >= 10 ? numAsInt % b2 - 10 + 'A' : numAsInt % b2 + '0');
    }
  }
}
