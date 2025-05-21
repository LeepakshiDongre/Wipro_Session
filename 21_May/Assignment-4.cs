// BACKTRACKING -  N QUEENS PROBLEM
using System;
using System.Collections.Generic;

class NQueens
{
    static void SolveNQueens(int n)
    {
        char[][] board = new char[n][];
        for (int i = 0; i < n; i++)
            board[i] = new string('.', n).ToCharArray();

        List<char[][]> results = new List<char[][]>();
        Solve(0, board, results);

        foreach (var solution in results)
        {
            foreach (var row in solution)
            {
                Console.WriteLine(new string(row));
            }
            Console.WriteLine();
        }
    }

    static void Solve(int row, char[][] board, List<char[][]> results)
    {
        int n = board.Length;
        if (row == n)
        {
            char[][] copy = new char[n][];
            for (int i = 0; i < n; i++)
                copy[i] = (char[])board[i].Clone();

            results.Add(copy);
            return;
        }

        for (int col = 0; col < n; col++)
        {
            if (IsSafe(board, row, col))
            {
                board[row][col] = 'Q';
                Solve(row + 1, board, results);
                board[row][col] = '.';
            }
        }
    }

    static bool IsSafe(char[][] board, int row, int col)
    {
        for (int i = 0; i < row; i++)
            if (board[i][col] == 'Q')
                return false;

        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            if (board[i][j] == 'Q')
                return false;

        for (int i = row - 1, j = col + 1; i >= 0 && j < board.Length; i--, j++)
            if (board[i][j] == 'Q')
                return false;

        return true;
    }

    static void Main()
    {
        int n = 4;
        SolveNQueens(n);
    }
}