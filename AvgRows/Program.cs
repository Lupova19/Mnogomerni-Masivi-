using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvgRows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int [2, 3 ];
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine($"Matrix = [{row}, {col}] = ");
                    matrix[row, col] = int.Parse( Console.ReadLine());
                }
               
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                long sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                    Console.WriteLine($"{matrix[i, j]}");
                }
                Console.WriteLine($"{(sum / 3) , 10:f2}");
            }
        }
    }
}
