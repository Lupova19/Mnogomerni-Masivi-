using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotarienBilet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split();
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            int[,] ticket = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    ticket[row, col] = int.Parse(line[col]);
                }
            }

            int DiagonalSum = 0;
            int DiagonalSum1 = 0;
            int upSum = 0;
            int downSum = 0;
            int evenOnPrimaryCount = 0;
            int evenCount = 0;
            int oddCount = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == col)
                    {
                        DiagonalSum += ticket[row, col];
                        if (ticket[row, col] % 2 == 0)
                        {
                            evenOnPrimaryCount++;
                        }
                    }

                    if (row + col == rows - 1)
                    {
                        DiagonalSum1 += ticket[row, col];
                    }

                    if (row < col)
                    {
                        upSum += ticket[row, col];
                    }

                    if (row > col)
                    {
                        downSum += ticket[row, col];
                    }

                    if (row == 0 || row == rows - 1 || col == 0 || col == cols - 1)
                    {
                        if (ticket[row, col] % 2 == 0)
                        {
                            evenCount++;
                        }
                        else
                        {
                            oddCount++;
                        }
                    }
                }
            }

            bool isWinning = DiagonalSum == DiagonalSum1 &&
                             upSum % 2 == 0 && downSum % 2 == 1;

            if (isWinning)
            {
                double prize = (downSum + evenOnPrimaryCount + evenCount + oddCount) / 4.0 * 2 - 0.5;
                Console.WriteLine($"Da! Specelenite pari sa: {prize:F2}");
            }
            else
            {
                Console.WriteLine("Ne!");
            }
        }
    }
}
