using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi br. redove: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Vavedi br. coloni: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] inputMatrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    inputMatrix[row, col] = int.Parse(Console.ReadLine());
                }

            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(inputMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
