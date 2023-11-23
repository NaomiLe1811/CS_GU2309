using System;
using System.Threading;
using System.Collections.Generic;
namespace Project_2_TicTacToe_OOP
{
    public class BotandBot : Player
    {
        public BotandBot(string name, char symbol) : base(name, symbol)
        {
        }

        // Override the GetMove method
        public override int GetMove(Board board)
        {
            // Your bot logic here
            // For simplicity, let's choose a random available move
            List<int> availableMoves = new List<int>();

            for (int i = 1; i <= 9; i++)
            {
                if (board.IsCellEmpty(i))
                {
                    availableMoves.Add(i);
                }
            }

            if (availableMoves.Count > 0)
            {
                // Introduce a delay of 1000 milliseconds (1 second)
                Thread.Sleep(1000);

                Random random = new Random();
                return availableMoves[random.Next(availableMoves.Count)];
            }

            // No available moves
            return -1;
        }
    }
}
