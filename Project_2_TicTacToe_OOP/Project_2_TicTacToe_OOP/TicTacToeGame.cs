using System;
using System.Threading;
namespace Project_2_TicTacToe_OOP
{
    public class TicTacToeGame
    {
        //class member
        private Board board;
        private Player player1;
        private Player player2;
        private Player currentPlayer;
        private int move = 1;

        //Constructor
        public TicTacToeGame(Board board, Player player1, Player player2)
        {
            
            this.board = board;
            this.player1 = player1;
            this.player2 = player2;
            currentPlayer = player1;
            move = 1;
        }

        //The Play method is where the game logic is implemented.
        public void Play()
        {
            do
            {
                Console.Clear();
                board.Display();

                Console.WriteLine($"Move {move}: {currentPlayer.Name}'s turn ({currentPlayer.Symbol})");

                int userInput;

                /*if (currentPlayer is Bot)
                {
                    userInput = ((Bot)currentPlayer).GetMove(board);
                }*/
                //Open when you want to bot vs bot
                if(currentPlayer is BotandBot)
                {
                    userInput = ((BotandBot)currentPlayer).GetMove(board);
                }
                else
                {
                    do
                    {
                        Console.Write("Enter a number (1-9) to place your symbol: ");
                    } while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 9 || !board.IsCellEmpty(userInput));

                    if (!board.IsCellEmpty(userInput))
                    {
                        Console.WriteLine("Invalid move. The selected cell is already occupied. Please choose an empty cell.");
                        continue;  // Restart the loop to allow the current player to make a valid move.
                    }
                }

                board.PlaceSymbol(userInput, currentPlayer.Symbol);

                // Check if the current player has won.
                if (board.CheckForWin(currentPlayer.Symbol))
                {
                    Console.Clear();
                    board.Display();
                    Console.WriteLine($"{currentPlayer.Name} wins!");
                    break;
                }

                move++;

                // Check if the game is a draw.
                if (move > 9)
                {
                    Console.Clear();
                    board.Display();
                    Console.WriteLine("It's a draw!");
                    break;
                }

                currentPlayer = (currentPlayer == player1) ? player2 : player1;

            } while (true);

            Console.WriteLine("Game Over!");
        }
    }
}