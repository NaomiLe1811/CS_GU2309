using System;

namespace Project2_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            IntializeBoard();// Step 2: Initialize the board

        }
        //2 dimensional, 3 rows 2 cols
        static char[,] board = new char[3, 3]; // Step 1: Board Representation
        static void IntializeBoard()
        {
            for(int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = ' '; // Step 2: Set all cells to empty
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
                PrintBoard();
            }
        }

        static void PrintBoard()
        {
            char cellValue = '1';
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = cellValue++;

                }
            }
        }
    }
}
