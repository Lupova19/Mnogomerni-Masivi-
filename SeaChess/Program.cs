using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaChess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi konfiguraciq za daska: ");
            char[,] board = new char[3, 3];

            for (int row = 0; row < 3; row++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int col = 0; col < 3; col++)
                {
                    if (line[col].Length > 0)
                    {
                        board[row, col] = line[col][0];
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '\0')
                {
                    Console.WriteLine($"Pobeditel e: {board[0, i]}");
                    return;
                }
            }
            if (board[0, 0] == board[1,1] && board[1, 1] == board[2, 2] && board[0, 0] != '\0')
            {
                Console.WriteLine($"Pobeditel e: {board[0, 0]}");
                return;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != '\0')
            {
                Console.WriteLine($"Pobeditel e: {board[0, 2]}");
                return;
            }
            Console.WriteLine("Nqma pobeditel!");
        }
    }
}
