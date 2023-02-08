using System;
using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class FibonacciNumberTests
  {
    [Fact]
    public void RecursiveTest1()
    {
      Assert.Equal(3, FibonacciNumber.Recursive(4));
    }

    [Fact]
    public void DynamicTest1()
    {
      Assert.Equal(3, FibonacciNumber.Dynamic(4));
    }

    [Fact]
    public void FibCacheO1Space()
    {
      Assert.Equal(3, FibonacciNumber.Cache01Space(4));
    }
  }
}
