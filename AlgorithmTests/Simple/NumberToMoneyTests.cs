using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class NumberToMoneyTests
  {
    [Fact]
    public void Thousand_Test()
    {
      Assert.Equal("532", NumberToMoney.Convert(532));
    }

    [Fact]
    public void Million_Test()
    {
      Assert.Equal("1M", NumberToMoney.Convert(1000000));
    }

    [Fact]
    public void Million_Double_Test()
    {
      Assert.Equal("2.5M", NumberToMoney.Convert(2500000.34));
    }

    [Fact]
    public void Billon_Test()
    {
      Assert.Equal("1.1B", NumberToMoney.Convert(1123456789));
    }

    [Fact]
    public void Trillion_Test()
    {
      Assert.Equal("9.5T", NumberToMoney.Convert(9487634567534));
    }

    [Fact]
    public void Zero_Test()
    {
      Assert.Equal("0", NumberToMoney.Convert(0));
    }

    [Fact]
    public void Negative_Number_Test()
    {
      Assert.Equal("-1M", NumberToMoney.Convert(-1000000));
    }
  }
}
