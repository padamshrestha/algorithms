using Algorithms.Hard;
using Xunit;

namespace AlgorithmTests.Hard
{
  public class BoardGameTests
  {
    [Fact]
    public void TestTicTacToe_ValidWin_Size3()
    {
      //Given
      // 0 No win
      // 1 First Player win
      // 2 Second Player win
      BoardGame bg = new BoardGame(3);

      //When
      var m1 = bg.move(0, 0, 1);
      var m2 = bg.move(1, 1, 2);
      var m3 = bg.move(0, 1, 1);
      var m4 = bg.move(2, 2, 2);
      var m5 = bg.move(0, 2, 1);

      //Then
      Assert.Equal(0, m1);
      Assert.Equal(0, m2);
      Assert.Equal(0, m3);
      Assert.Equal(0, m4);
      Assert.Equal(1, m5);
    }

    [Fact]
    public void TestTicTacToe_ValidWin_Size2()
    {
      //Given
      // 0 No win
      // 1 First Player win
      // 2 Second Player win
      BoardGame bg = new BoardGame(2);

      //When
      var m1 = bg.move(0, 1, 1);
      var m2 = bg.move(1, 1, 2);
      var m3 = bg.move(1, 0, 1);

      //Then
      Assert.Equal(0, m1);
      Assert.Equal(0, m2);
      Assert.Equal(1, m3);
    }
  }
}

