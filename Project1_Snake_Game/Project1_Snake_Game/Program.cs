using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Project1_Snake_Game
{
    class Program
    {
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        const int height = 10;
        const int width = 30;
        //const int panel = 10;

        static void Main(string[] args)
        {
     
        ShowBanner();
        //DrawBox();


        }

        public static void ShowBanner()
        {
            ConsoleKeyInfo keypress;
            //Console.SetWindowSize(width, height + panel);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.CursorVisible = false;      //ẩn con trỏ

            Console.WriteLine("============================================");
            Console.WriteLine("=================SNAKE GAME=================");
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("Press space to play");
            Console.WriteLine("Tips: - Use Arrow button to move the snake");
            Console.WriteLine("      - Press key P to pause game         ");
            Console.WriteLine("      - Press key R to reset game         ");
            Console.WriteLine("      - Press key Q to quit game          ");

            Console.WriteLine(); // Add extra newline characters to simulate window height

            Console.Write("╔");
            for (int i = 0; i < width; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╗");

            // Draw side borders
            for (int i = 0; i < height; i++)
            {
                Console.Write("║");
                Console.Write(new string(' ', width));
                Console.WriteLine("║");
            }

            // Draw bottom border
            Console.Write("╚");
            for (int i = 0; i < width; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╝");


            keypress = Console.ReadKey(true);
            if (keypress.Key == ConsoleKey.Spacebar)
                Console.WriteLine("Game started! Use arrow keys to control the snake.");
            if (keypress.Key == ConsoleKey.Q)
                Environment.Exit(0);
            
        }

       

       
    }
}
