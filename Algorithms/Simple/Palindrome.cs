using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Algorithms.Simple
{
  public class Palindrome
  {
    public static bool IsPalindrome(string inputString)
    {

      if (String.IsNullOrEmpty(inputString))
      {
        return true;
      }

      var rg = new Regex(@"[^a-zA-Z0-9]");
      var charArray = rg.Replace(inputString.Trim(), String.Empty).ToLower();

      for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
      {
        if (charArray[i] != charArray[j])
        {
          return false;
        }
      }

      return true;
    }
  }
}
