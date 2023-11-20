using System;
using System.Threading;
namespace Project2_TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];
        static char currentPlayer = 'X';
        static int moves = 0;
        static char winner = ' '; // Variable to store the winner

        static void Main(string[] args)
        {
            InitializeBoard();
            PlayGameBotVsBot();

            Console.ReadKey();
        }

        static void PlayGameBotVsBot()
        {
            bool gameWon = false;

            do
            {
                Console.Clear();
                PrintBoard();

                Console.WriteLine($"Player {currentPlayer}'s turn.");

                BotMakeMove();
                moves++;
                gameWon = CheckForWin();
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';

                // Add a delay between bot moves for better visibility
                Thread.Sleep(1000);

            } while (!gameWon && moves < 9);
        }

        // BotMakeMove method remains the same as in Version 1

        // Remaining methods unchanged...
        static void PrintBoard()
        {
            Console.WriteLine("Current Board:");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Welcome to Tic Tac Toe game");
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

        static void BotMakeMove()
        {
            // Implement bot's move logic here
            // For simplicity, you can make a random move for the bot
            Random random = new Random();
            int botMove;
            int row, col;
            do
            {
                botMove = random.Next(1, 10);
                NumberToRowCol(botMove, out row, out col);
            } while (!IsValidMove(row, col));

            Console.WriteLine($"Bot chose {botMove}");
            board[row, col] = currentPlayer;
        }

        static int GetPlayerInput()
        {
            Console.WriteLine("Enter a number to make a move (from 1 - 9)");
            int moveNumber = int.Parse(Console.ReadLine());

            if (moveNumber < 1 || moveNumber > 9 || board[(moveNumber - 1) / 3, (moveNumber - 1) % 3] != ' ')
            {
                Console.WriteLine("Invalid move.");
                return GetPlayerInput();
            }

            return moveNumber;
        }

        static void NumberToRowCol(int moveNumber, out int row, out int col)
        {
            row = (moveNumber - 1) / 3;
            col = (moveNumber - 1) % 3;
        }

        static bool IsValidMove(int row, int col)
        {
            return (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == ' ');
        }

        static bool CheckForWin()
        {
            // Check for a win after a minimum of three moves
            if (moves < 3)
                return false;

            // Check for a win in rows, columns, diagonals, and anti-diagonals
            for (int i = 0; i < 3; i++)
            {
                if (CheckRow(i) || CheckColumn(i))
                {
                    winner = currentPlayer;
                    return true;
                }
            }

            if (CheckDiagonals() || CheckAntiDiagonals())
            {
                winner = currentPlayer;
                return true;
            }

            return false;
        }

        static bool CheckRow(int row)
        {
            return (board[row, 0] == currentPlayer && board[row, 1] == currentPlayer && board[row, 2] == currentPlayer);
        }

        static bool CheckColumn(int col)
        {
            return (board[0, col] == currentPlayer && board[1, col] == currentPlayer && board[2, col] == currentPlayer);
        }

        static bool CheckDiagonals()
        {
            return (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer);
        }

        static bool CheckAntiDiagonals()
        {
            return (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer);
        }
    }
}
