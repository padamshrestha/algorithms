using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class PalindromeTests
  {
    [Fact]
    public void EvaluateTrue()
    {
      Assert.True(Palindrome.IsPalindrome("A man, a plan, a canal: Panama"));
    }

    [Fact]
    public void EvaluateFalse1()
    {
      Assert.False(Palindrome.IsPalindrome("race a car"));
    }


    [Fact]
    public void EvaluateFalse2()
    {
      Assert.False(Palindrome.IsPalindrome("abb"));
    }
  }
}