using System;

namespace mtrix
{
    class Matrix
    {
        static void Main()
        {
            int[,] matrix = new int[3,3];
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            int cellIndex = 3;
            for (int row = 0; row < rowsCount; row++)
            {
                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = cellIndex;
                    cellIndex++;
                    Console.Write(matrix[row,col]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
