using System;

namespace Project2_TicTacToe
{
    class Program
    {
        static char[,] board = new char[3, 3]; // Step 1: Board Representation
        static char currentPlayer = 'X'; // Step 3: Current player starts with 'X'
        static void Main(string[] args)
        {
            InitializeBoard(); // Step 2: Initialize the board
            PlayGame();

            Console.ReadKey();
        }

        // 2-dimensional, 3 rows 3 cols
        static void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' '; // Beginning step: Set all cells to empty
                }
            }
        }

        static void PlayGame()
        {
            bool gameWon = false;
            int moves = 0;

            do
            {
                Console.Clear();
                PrintBoard(); // Step 1: Print the board

                // Step 2: Ask users to input
                Console.WriteLine($"Player {currentPlayer}'s turn.");
                int playerInput = GetPlayerInput();

                // Step 3: Check if the move is valid
                int row, col;
                NumberToRowCol(playerInput, out row, out col);

                if (IsValidMove(row, col))
                {
                    board[row, col] = currentPlayer;
                    moves++;

                    gameWon = CheckForWin(row, col);
                    SetRandomColor(); // Set a random color for the symbols

                    // Step 4: Switch players
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }

            } while (!gameWon && moves < 9);

            if (gameWon)
            {
                Console.WriteLine($"Player {currentPlayer} wins!");
            }
            else
            {
                Console.WriteLine("The game is a tie!");
            }
        }

        static void PrintBoard()
        {
            Console.WriteLine("Current Board:");

            char cellValue = '1';
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write((board[row, col] == ' ') ? cellValue.ToString() : board[row, col].ToString());
                    Console.Write(" ");
                    ResetConsoleColor(); 
                   cellValue++;
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Welcome to Tic Tac Toe game");
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

        static bool CheckForWin(int row, int col)
        {
            return (CheckRow(row) || CheckColumn(col) || CheckDiagonals() || CheckAntiDiagonals());
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

        static void SetRandomColor()
        {
            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            Console.ForegroundColor = colors[random.Next(colors.Length)];

        }
        static void ResetConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.Gray; // Reset to the default console color (gray)
        }
    }
}