using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class StringConversionTests
  {
    [Fact]
    public void IntToString_Test()
    {
      Assert.Equal("123", StringConversion.IntToString(123));
      Assert.Equal("-123", StringConversion.IntToString(-123));
      Assert.Equal("0", StringConversion.IntToString(0));
    }

    [Fact]
    public void StringToInt_Test()
    {
      Assert.Equal(123, StringConversion.StringToInt("123"));
      Assert.Equal(-123, StringConversion.StringToInt("-123"));
    }

    [Fact]
    public void ConvertBase_Test()
    {
      Assert.Equal("1A7", StringConversion.ConvertBase("615", 7, 13));
      Assert.Equal("149A", StringConversion.ConvertBase("3000", 10, 13));
    }
  }
}
