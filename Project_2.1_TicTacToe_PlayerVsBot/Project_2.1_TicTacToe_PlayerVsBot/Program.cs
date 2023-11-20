using System;

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
                        gameWon = CheckForWin();
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

            Console.Clear();
            PrintBoard();

            if (gameWon)
            {
                Console.WriteLine($"Player {winner} wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
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

        // Remaining methods unchanged...

        // You may need to adjust the CheckForWin method to handle bot moves.

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
                    //ResetConsoleColor();
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

        /*static void SetRandomColor()
        {
            ConsoleColor[] colors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Random random = new Random();
            Console.ForegroundColor = colors[random.Next(colors.Length)];

        }
        static void ResetConsoleColor()
        {
            Console.ForegroundColor = ConsoleColor.Gray; // Reset to the default console color (gray)
        }*/
    }
}