using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinOfCols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];
            List<int> result = new List<int>();

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                List<int> list = new List<int>();
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.WriteLine($"Matrix[{j}, {i}]= ");
                    matrix[j, i] = int.Parse(Console.ReadLine());
                    list.Add(matrix[j, i]);
                }
                result.Add(list.Min());
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
