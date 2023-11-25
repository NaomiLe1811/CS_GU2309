using System;
using System.Collections.Generic;


namespace Project_2_TicTacToe_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");

            // Create the game board
            Board board = new Board();

            // Uncomment one of the following sections based on your preference:

            // Case 1: Two Human Players
            //Player player1 = new Player("Player 1", 'X');
            //Player player2 = new Player("Player 2", 'O');
            //TicTacToeGame game = new TicTacToeGame(board, player1, player2);

             //Case 2: Human Player vs. Bot

            Player player1 = new Player("Player 1", 'X');
            Bot bot = new Bot("Bot", 'O');
            TicTacToeGame game = new TicTacToeGame(board, player1, bot);


            // Case 3: Two Bots

            //BotandBot bot1 = new BotandBot("Bot 1", 'X');
            //BotandBot bot2 = new BotandBot("Bot 2", 'O');
            //TicTacToeGame game = new TicTacToeGame(board, bot1, bot2);


            // Play the game
            game.Play();

            Console.ReadKey();
        }
    }
}
