using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaxPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, i] = int.Parse(line[j]);
                }
            }
            int maxValue = int.MinValue;
            int maxRow = -1;
            int maxCol = -1;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row , col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    maxValue = sum;
                    maxRow = row;
                    maxCol = col;
                }
                Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
                Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            }
        }
    }
}
