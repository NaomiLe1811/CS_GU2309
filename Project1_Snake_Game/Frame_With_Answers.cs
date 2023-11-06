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

        // Định nghĩa hướng di chuyển
        enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }

        // Định nghĩa tọa độ
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

        static void Main(string[] args)
        {
            // Khởi tạo cửa sổ console và các biến cần thiết
            Console.Title = "Snake Game";
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height + 2);

            // Khởi tạo danh sách con rắn, hướng di chuyển và đối tượng thức ăn
            List<Position> snake = new List<Position>();
            Direction direction = Direction.Right;
            Random rand = new Random();
            Position food = new Position(rand.Next(0, width), rand.Next(0, height));

            // Thêm đầu con rắn vào danh sách
            snake.Add(new Position(width / 2, height / 2));

            // Vòng lặp chính
            while (!gameOver)
            {
                // Xử lý đầu vào từ bàn phím
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    switch (key.Key)
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

                // Cập nhật vị trí của con rắn
                // Kiểm tra va chạm
                // Cập nhật điểm số
                // Vẽ lại các đối tượng trên màn hình console

                // Ngừng một lúc trước khi cập nhật lại màn hình
                Thread.Sleep(100);
            }

            // Khi trò chơi kết thúc, hiển thị thông báo "Game Over!"
            // Dừng chương trình và chờ người chơi nhấn một phím bất kỳ để thoát
        }
    }
}