using System;
using System.Collections.Generic;

namespace Algorithms.Hard
{
  public class NQueens
  {
    public List<char[,]> Solve(int n)
    {

      var ans = new List<char[,]>();
      var board = new char[n, n];

      SolveBoard(ans, board, 0, n);

      return ans;
    }

    private void SolveBoard(List<char[,]> ans, char[,] board, int col, int n)
    {
      if (col == n)
      {
        ans.Add(board);
        return;
      }

      for (var row = 0; row < n; row++)
      {
        if (ValidateSpot(board, row, col))
        {
          board[row, col] = 'Q';
          SolveBoard(ans, board, col + 1, n);
          board[row, col] = '.';
        }
      }
    }

    private bool ValidateSpot(char[,] board, int row, int col)
    {
      var n = board.GetLowerBound(0);

      for (var i = 1; i < col; i++)
      {
        if (board[row, col - i] == 'Q') return false;
      }

      for (var i = 1; row - i >= 0 && col - i >= 0; i++)
      {
        if (board[row - i, col - i] == 'Q') return false;
      }

      for (var i = 1; row + i < n && col - i <= 0; i++)
      {
        if (board[row + i, col - i] == 'Q') return false;
      }

      return true;
    }
  }
}
