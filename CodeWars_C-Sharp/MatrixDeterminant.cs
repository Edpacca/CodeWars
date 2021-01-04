using System;
using System.Collections.Generic;

// Write a function that accepts a square matrix (N x N 2D array) and returns the determinant of the matrix.

namespace CodeWars
{
    class MatrixDeterminant
    {
        public static int Determinant(int[][] matrix)
        {
            if (matrix.Length == 1)
                return matrix[0][0];

            if (matrix.Length == 2)
                return Calc2x2Determinant(matrix);

            var determinant = 0;
            var sign = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                sign = i % 2 == 0 ? 1 : -1;

                if (matrix.Length == 3)
                    determinant += matrix[0][i] * Calc2x2Determinant(GetDetMatrix(matrix, 0, i)) * sign;
                else
                    determinant += matrix[0][i] * CalcNxNDeterminant(GetDetMatrix(matrix, 0, i)) * sign;
            }

            return determinant;
        }

        public static int[][] GetDetMatrix(int[][] matrix, int rowCof, int colCof)
        {
            var size = matrix.Length;

            int[][] NewMatrix = new int[size - 1][];
            var bufferRows = new List<int[]>();
            var bufferRow = new List<int>();


            for (int i = 0; i < size; i++)
            {
                if (i != rowCof)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j != colCof)
                            bufferRow.Add(matrix[i][j]);
                    }

                    bufferRows.Add(bufferRow.ToArray());
                    bufferRow.Clear();
                }
            }

            return bufferRows.ToArray();
        }

        public static int Calc2x2Determinant(int[][] matrix)
        {
            if (matrix.Length != 2)
                throw new ArgumentException("matrix must be 2x2 to calculate determinant directly");

            return (matrix[0][0] * matrix[1][1]) - (matrix[0][1] * matrix[1][0]);
        }

        public static int CalcNxNDeterminant(int[][] matrix)
        {
            var determinant = 0;
            var sign = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                sign = i % 2 == 0 ? 1 : -1;

                if (matrix.Length == 3)
                    determinant += matrix[0][i] * Calc2x2Determinant(GetDetMatrix(matrix, 0, i)) * sign;

                determinant += matrix[0][i] * CalcNxNDeterminant(GetDetMatrix(matrix, 0, i)) * sign;
            }

            return determinant;
        }
    }
}
