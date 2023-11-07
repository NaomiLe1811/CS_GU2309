using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static int height = 20;
        static int width = 40;
        static int score = 0;
        static Direction direction; // declare the direction variable as a static member in SnakeMovement()
        static bool gameOver = false;

        enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        struct Position
        {
            public int x;
            public int y;
            public Position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static List<Position> snake = new List<Position>(); //theo doi vi tri con ran
        static Position food = new Position(); //theo doi vi tri fruit

        static void InitializeGameArea()
        {
            snake.Add(new Position(width / 2, height / 2)); //vi tri bat dau con ran
            //SpawnFood(); //ko de day dc vi initialgameare la static
        }

        static void SpawnFood()
        {
            var random = new Random();
            food = new Position(random.Next(0, width), random.Next(0, height));
        }

        //update the display after each
        static void DrawGameArea()
        {
            Console.Clear(); //clear the console before updating the display
            Console.ForegroundColor = ConsoleColor.Green;

            //ve fruit
            Console.SetCursorPosition(food.x, food.y);
            Console.Write("@");

            //ve con ran
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var position in snake)
            {
                Console.SetCursorPosition(position.x, position.y);
                Console.Write("o");
            }

            // vị trí con trỏ
            Console.SetCursorPosition(0, height);
            // ve diem so
            Console.Write($"Score: {score}");
        }

        static void SnakeMovement()
        {
            //di chuyển các phần tử trong danh sách snake
            for (int i = snake.Count - 1; i >= 1; i--)
            {
                snake[i] = new Position(snake[i - 1].x, snake[i - 1].y);
            }

            //
            switch (direction) //lay tu tren enum xuong
            {
                case Direction.Up:
                    snake[0] = new Position(snake[0].x, snake[0].y - 1);
                    break;
                case Direction.Down:
                    snake[0] = new Position(snake[0].x, snake[0].y + 1);
                    break;
                case Direction.Left:
                    snake[0] = new Position(snake[0].x - 1, snake[0].y);
                    break;
                case Direction.Right:
                    snake[0] = new Position(snake[0].x + 1, snake[0].y);
                    break;
            }
        }

        static void Collision()
        {
            //con ran cham trai cay
            if (snake[0].x == food.x && snake[0].y == food.y)
            {
                snake.Add(new Position()); //new snake
                score += 10;
                SpawnFood();
            }

            //con ran co cham margin ko
            if (snake[0].x < 0 || snake[0].x >= width || snake[0].y < 0 || snake[0].y >= height)
            {
                gameOver = true;
            }

            //con ran co cham body ko
            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[0].x == snake[i].x && snake[0].y == snake[i].y)
                {
                    gameOver = true;
                }
            }
        }

        //xử lý đầu vào từ bàn phím và điều chỉnh hướng di chuyển của con rắn.SnakeMovement để di chuyển con rắn, tuy nhiên, cần một cách để chương trình phản ứng với người chơi và thay đổi hướng di chuyển của con rắn dựa trên phím mũi tên mà người chơi nhấn vào bàn phím.

        static void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (direction != Direction.Down)
                            direction = Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        if (direction != Direction.Up)
                            direction = Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (direction != Direction.Right)
                            direction = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        if (direction != Direction.Left)
                            direction = Direction.Right;
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Snake Game";
            Console.CursorVisible = false;

            InitializeGameArea();
            SpawnFood();

            while (!gameOver)
            {
                //cho phep user di chuyen (priority = > de cho khac se di chuyen cham)
                ProcessInput();
                //sau khi nhan nut => con ran thay doi vi tri
                SnakeMovement();
                //Neu con ran cham
                Collision();
                //update the display
                DrawGameArea();
                Thread.Sleep(150);
            }

            Console.SetCursorPosition(width / 2 - 5, height / 2);
            Console.WriteLine("Game Over");
            Console.SetCursorPosition(width / 2 - 10, height / 2 + 1);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}