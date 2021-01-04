using System.Collections.Generic;

// Write a function validSolution/ValidateSolution/valid_solution() that accepts a 2D array representing a Sudoku board, and returns true if it is a valid solution, or false otherwise. 
// The cells of the sudoku board may also contain 0's, which will represent empty cells. 
// Boards containing one or more zeroes are considered to be invalid solutions.
// The board is always 9 cells by 9 cells, and every cell only contains integers from 0 to 9.

namespace CodeWars
{
    class SudokuSolutionValidator
    {
        public static bool ValidateSolution(int[][] board)
        {
            if (board.Length != 9)
                return false;

            var LineList = new List<int>();

            foreach (var line in board)
            {
                foreach (var number in line)
                {
                    if (LineList.Contains(number))
                        return false;

                    LineList.Add(number);
                }

                LineList.Sort();

                for (int i = 0; i < 9; i++)
                    if (LineList[i] != i + 1)
                        return false;

                LineList.Clear();
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (LineList.Contains(board[j][i]))
                        return false;

                    LineList.Add(board[j][i]);
                }

                LineList.Sort();
                for (int k = 0; k < 9; k++)
                    if (LineList[i] != i + 1)
                        return false;

                LineList.Clear();
            }

            var Rows3x3 = 0;
            var Cols3x3 = 0;
            var sum = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int l = 0; l < 3; l++)
                {
                    for (int j = Rows3x3; j < Rows3x3 + 3; j++)
                    {
                        for (int k = Cols3x3; k < Cols3x3 + 3; k++)
                            sum += board[j][k];
                    }

                    if (sum != 45)
                        return false;
                    sum = 0;
                    Rows3x3 += 3;
                }
                Rows3x3 = 0;
                Cols3x3 += 3;
            }

            return true;
        }
    }
}
