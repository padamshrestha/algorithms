using Algorithms.Simple;
using Xunit;

namespace AlgorithmTests.Simple
{
  public class ExcelSheelColumnTitleTests
  {
    [Fact]
    public void TestEqual()
    {
      Assert.Equal("A", ExcelSheelColumnTitle.Calculate(1));
      Assert.Equal("AB", ExcelSheelColumnTitle.Calculate(28));
      Assert.Equal("ZY", ExcelSheelColumnTitle.Calculate(701));
      Assert.Equal("FXSHRXW", ExcelSheelColumnTitle.Calculate(2147483647));
    }
  }
}
