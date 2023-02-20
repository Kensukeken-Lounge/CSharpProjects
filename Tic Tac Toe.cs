using System;

namespace TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];

        static void Main(string[] args)
        {
            InitializeBoard();
            PrintBoard();

            char player = 'X';

            while (true)
            {
                Console.Write($"Player {player}, enter row number: ");
                int row = int.Parse(Console.ReadLine()) - 1;

                Console.Write($"Player {player}, enter column number: ");
                int col = int.Parse(Console.ReadLine()) - 1;

                if (board[row, col] != ' ')
                {
                    Console.WriteLine("Invalid move. Try again.");
                    continue;
                }

                board[row, col] = player;
                PrintBoard();

                if (IsWin(player))
                {
                    Console.WriteLine($"Player {player} wins!");
                    break;
                }

                if (IsTie())
                {
                    Console.WriteLine("It's a tie!");
                    break;
                }

                player = player == 'X' ? 'O' : 'X';
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' ';
                }
            }
        }

        static void PrintBoard()
        {
            Console.WriteLine("  1 2 3");

            for (int row = 0; row < 3; row++)
            {
                Console.Write(row + 1);

                for (int col = 0; col < 3; col++)
                {
                    Console.Write($" {board[row, col]}");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static bool IsWin(char player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                {
                    return true;
                }

                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                {
                    return true;
                }
            }

            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                return true;
            }

            if (board[2, 0] == player && board[1, 1] == player && board[0, 2] == player)
            {
                return true;
            }

            return false;
        }

        static bool IsTie()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
