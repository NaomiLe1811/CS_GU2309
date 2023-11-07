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

        static List<Position> snake = new List<Position>();
        static Position food = new Position();

        static void InitializeGameArea()
        {
            snake.Add(new Position(width / 2, height / 2));
            //Console.SetBufferSize(width, height);
            //Console.SetWindowSize(width, height + 2);
        }

        static void DrawGameArea()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(food.x, food.y);
            Console.Write("@");

            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var position in snake)
            {
                Console.SetCursorPosition(position.x, position.y);
                Console.Write("o");
            }

            Console.SetCursorPosition(0, height);
            Console.Write($"Score: {score}");
        }

        static void MoveSnake()
        {
            for (int i = snake.Count - 1; i >= 1; i--)
            {
                snake[i] = new Position(snake[i - 1].x, snake[i - 1].y);
            }

            switch (direction)
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

        static void HandleCollisions()
        {
            if (snake[0].x == food.x && snake[0].y == food.y)
            {
                snake.Add(new Position());
                score += 10;
                SpawnFood();
            }

            if (snake[0].x < 0 || snake[0].x >= width || snake[0].y < 0 || snake[0].y >= height)
            {
                gameOver = true;
            }

            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[0].x == snake[i].x && snake[0].y == snake[i].y)
                {
                    gameOver = true;
                }
            }
        }

        static void SpawnFood()
        {
            var random = new Random();
            food = new Position(random.Next(0, width), random.Next(0, height));
        }

        static Direction direction = Direction.Right;

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
                ProcessInput();
                MoveSnake();
                HandleCollisions();
                DrawGameArea();
                Thread.Sleep(200);
            }

            Console.SetCursorPosition(width / 2 - 5, height / 2);
            Console.WriteLine("Game Over");
            Console.SetCursorPosition(width / 2 - 10, height / 2 + 1);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}