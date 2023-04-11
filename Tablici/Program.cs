using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi br. sheets: ");
            int n = int.Parse(Console.ReadLine());
            int[][][] sheets = new int[n][][];

            for (int i = 0; i < n; i++)
            {
                int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray(); //
                int rows = size[0];
                int cols = size[1];
                sheets[i] = new int[rows][];
                for (int row = 0; row < rows; row++)
                {
                    int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    sheets[i][row] = values;
                }
            }
            double[] sheetsAvg = new double[n];
            for (int i = 0; i < n; i++)
            {
                int min = sheets[i][0][0];
                int max = sheets[i][0][0];
                int sum = 0;
                
                for (int row = 0; row < sheets[i].Length; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        int value = sheets[i][row][col];

                        if (value < min)
                        {
                            min = value;
                        }else if (value > max)
                        {
                            max = value;
                        }
                        sum += value;
                    }
                }
                double avg = (double)sum / (sheets[i].Length * sheets[i][0].Length);
                sheetsAvg[i] = avg;
                Console.WriteLine($"{min} {max} {Math.Round(avg, 2)}");
            }
            double documentAvg = sheetsAvg.Average();
            for (int i = 0;i < sheetsAvg.Length; i++)
            {
                if (sheetsAvg[i] > documentAvg)
                {
                    Console.Write("2");
                }
                else
                {
                    Console.Write("4");
                }
            }
            Console.WriteLine();


        }
    }
}
