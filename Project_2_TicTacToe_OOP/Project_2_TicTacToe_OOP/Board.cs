using System;
namespace Project_2_TicTacToe_OOP
{
    public class Board
    {
        //member variable
        private char[,] cells;

        //constructor
        public Board()
        {
            cells = new char[3, 3];
            InitializeBoard();
        }

        //initialized
        private void InitializeBoard()
        {
            char num = '1';

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells[i, j] = num++;
                }
            }
        }

        //display
        public void Display()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char symbol = cells[i, j];
                    ConsoleColor color = GetSymbolColor(symbol);

                    Console.ForegroundColor = color;
                    Console.Write(symbol + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        private ConsoleColor GetSymbolColor(char symbol)
        {
            // You can assign different colors for different symbols
            // Here, 'X' is assigned blue, 'O' is assigned red, and default is white
            switch (symbol)
            {
                case 'X':
                    return ConsoleColor.Blue;
                case 'O':
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Black;
            }
        }

        // Checking if a cell is empty based on its number
        public bool IsCellEmpty(int number)
        {
            int row = (number - 1) / 3;
            int col = (number - 1) % 3;
            return cells[row, col] == number.ToString()[0];
        }

        // Placing a symbol on the board based on the cell number
        public void PlaceSymbol(int number, char symbol)
        {
            int row = (number - 1) / 3;
            int col = (number - 1) % 3;
            cells[row, col] = symbol;
        }

        // Checking for a win in rows, columns, and diagonals
        public bool CheckForWin(char symbol)
        {
            // Check rows, columns, and diagonals for a win
            for (int i = 0; i < 3; i++)
            {
                if ((cells[i, 0] == symbol && cells[i, 1] == symbol && cells[i, 2] == symbol) ||
                    (cells[0, i] == symbol && cells[1, i] == symbol && cells[2, i] == symbol))
                {
                    return true;
                }
            }

            if ((cells[0, 0] == symbol && cells[1, 1] == symbol && cells[2, 2] == symbol) ||
                (cells[0, 2] == symbol && cells[1, 1] == symbol && cells[2, 0] == symbol))
            {
                return true;
            }

            return false;
        }
    }
}
