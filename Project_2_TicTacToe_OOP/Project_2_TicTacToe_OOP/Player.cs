using System;
namespace Project_2_TicTacToe_OOP
{
    public class Player
    {
         public string Name { get; }
    public char Symbol { get; }

    public Player(string name, char symbol)
    {
        Name = name;
        Symbol = symbol;
    }

    // Declare the GetMove method as virtual to allow overriding
    public virtual int GetMove(Board board)
    {
        // Default implementation (for human players, for example)
        int userInput;
        do
        {
            Console.Write("Enter a number (1-9) to place your symbol: ");
        } while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 9 || !board.IsCellEmpty(userInput));
        return userInput;
    }
    }
}
