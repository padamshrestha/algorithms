namespace Algorithms.Hard
{
  interface IBoardGame
  {
    int move(int row, int col, int player);
    int validateBoard(int row, int col, int player);
    bool ValidateRow(int currentRow, int player);
    bool ValidateColum(int currentColumn, int player);
    bool checkForwardDiagonal(int player);
    bool checkBackwardDiagonal(int player);
  }

  public class BoardGame : IBoardGame
  {
    private int size;
    private int[,] board;

    public BoardGame(int n)
    {
      size = n;
      board = new int[n, n];
    }

    public int move(int row, int col, int player)
    {
      if (player == 1)
      {
        board[row, col] = 1;
      }
      else
      {
        board[row, col] = 2;
      }
      return validateBoard(row, col, player);
    }

    public int validateBoard(int row, int col, int player)
    {
      if (ValidateRow(row, player) || ValidateColum(col, player))
      {
        return player;
      }
      else if (row == col && checkForwardDiagonal(player))
      {
        return player;
      }
      else if (col == size - row - 1 && checkBackwardDiagonal(player))
      {
        return player;
      }
      return 0;
    }

    public bool ValidateRow(int currentRow, int player)
    {
      for (int column = 0; column < size; column++)
      {
        if (board[currentRow, column] != player)
        {
          return false;
        }
      }
      return true;
    }

    public bool ValidateColum(int currentColumn, int player)
    {
      for (int row = 0; row < size; row++)
      {
        if (board[row, currentColumn] != player)
        {
          return false;
        }
      }
      return true;
    }

    public bool checkForwardDiagonal(int player)
    {
      for (int x = 0; x < size; x++)
      {
        if (board[x, x] != player)
        {
          return false;
        }
      }
      return true;
    }

    public bool checkBackwardDiagonal(int player)
    {
      for (int x = 0; x < size; x++)
      {
        if (board[size - x - 1, x] != player)
        {
          return false;
        }
      }
      return true;
    }

  }
}
