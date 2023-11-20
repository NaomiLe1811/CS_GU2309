using System;

namespace Project2_TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3];
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            InitializeBoard();
            PlayGameVsBot();

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

        static void PlayGameVsBot()
        {
            bool gameWon = false;
            int moves = 0;

            do
            {
                Console.Clear();
                PrintBoard();

                Console.WriteLine($"Player {currentPlayer}'s turn.");

                if (currentPlayer == 'X')
                {
                    int playerInput = GetPlayerInput();
                    int row, col;
                    NumberToRowCol(playerInput, out row, out col);

                    if (IsValidMove(row, col))
                    {
                        board[row, col] = currentPlayer;
                        moves++;
                        gameWon = CheckForWin(row, col);
                        currentPlayer = 'O';
                    }
                    else
                    {
                        Console.WriteLine("Invalid move. Try again.");
                    }
                }
                else // Bot's turn
                {
                    BotMakeMove();
                    moves++;
                    gameWon = CheckForWin();
                    currentPlayer = 'X';
                }

            } while (!gameWon && moves < 9);
        }

        static void BotMakeMove()
        {
            // Implement bot's move logic here
            // For simplicity, you can make a random move for the bot
            Random random = new Random();
            int botMove;
            do
            {
                botMove = random.Next(1, 10);
                int row, col;
                NumberToRowCol(botMove, out row, out col);
            } while (!IsValidMove(row, col));

            Console.WriteLine($"Bot chose {botMove}");
            board[row, col] = currentPlayer;
        }

        // Remaining methods unchanged...

        // You may need to adjust the CheckForWin method to handle bot moves.
    }
}