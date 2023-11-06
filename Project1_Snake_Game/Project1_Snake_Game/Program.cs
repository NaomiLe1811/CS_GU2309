using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Project1_Snake_Game
{
    class Program
    {
        ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        public Random rand = new Random();
        const int height = 20;
        const int width = 40;
        string dir, pre_dir;
        //const int panel = 10;
        public int score, headX, headY, fruitX, fruitY, typeFruit, nTail;
        int[] TailX = new int[100]; 
        int[] TailY = new int[100];
        bool gameOver, reset, isprinted, horizontal, vertical;
        List<(int, int)> snake; // List to store the coordinates of the snake's body segments


        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowBanner();
            while (true)
            { 
            program.SetUp();
            program.Update();
            Console.Clear();
            }

        }

        public void ShowBanner()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            ConsoleKeyInfo keypress;
            //Console.SetWindowSize(width, height + panel);
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
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

            Console.WriteLine();

            keypress = Console.ReadKey(); //the data type is not explicitly stated because the Console.ReadKey() method returns a ConsoleKeyInfo object.
            if (keypress.Key == ConsoleKey.Spacebar)
                //GameStart();
                if (keypress.Key == ConsoleKey.Q)
                    Environment.Exit(0);
            if (keypress.Key == ConsoleKey.P)
                Console.ReadLine(); // Wait for the player to press Enter to resume
            if (keypress.Key == ConsoleKey.R)
            {
                Console.Clear();
            }

        }
        public void SetUp()
        {
            dir = "RIGHT"; pre_dir = ""; //control the movement of the snake and ensure that it moves in the desired direction based on the user's input
            score = 0;
            gameOver = false;

            // Initialize the snake with a starting length and position within the playable area
            headX = width / 2; // Snake head X-coordinate in the center of the playable area
            headY = height / 2; // Snake head Y-coordinate in the center of the playable area

            randomQua();

        }

        //Random diem an qua
        void randomQua()
        {
            fruitX = rand.Next(1, width - 2);
            fruitY = rand.Next(1, height - 2);
            typeFruit = rand.Next(1, 5);
        }

        //In ra man hinh

        void Render()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)      //vien khung
                        Console.Write("═");
                    else if (j == 0 || j == width - 1)  //vien khung
                        Console.Write("║");
                    else if (j == fruitX && i == fruitY)//in qua len man hinh
                    {
                        Console.Write(typeFruit);
                    }
                    else if (j == headX && i == headY)
                    { //Dau con ran
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("0");

                    }
                    else
                    {
                        isprinted = false; //chua hieu cai nay
                        for (int k = 0; k < nTail; k++)
                        {
                            if (TailX[k] == j && TailY[k] == i)
                            {
                                Console.Write("o");     //Than con ran
                                isprinted = true;
                            }
                        }
                        if (!isprinted) Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Your score: " + score);
            GameStart();
        }

        void GameStart()
        {
            Console.WriteLine("Game started! Use arrow keys to control the snake.");
        }

        void Update()
        {
            while (!gameOver)
            {
            CheckInput(); //nhận lệnh điều hướng
            Logic();      //xử lý lệnh điều hướng
            Render();     //in ra màn hình  
            if (reset) break;
            Thread.Sleep(100);
            }

            if (gameOver)
                Lose();
        }
        //dieu khien phim
        void CheckInput()
        {
            while (Console.KeyAvailable)
            {
                keypress = Console.ReadKey(true);
                pre_dir = dir;  //backup hướng di chuyển trước đó 
                switch (keypress.Key)
                {
                    case ConsoleKey.Q: Environment.Exit(0); break;
                    case ConsoleKey.P: dir = "STOP"; break;
                    case ConsoleKey.LeftArrow: dir = "LEFT"; break;
                    case ConsoleKey.RightArrow: dir = "RIGHT"; break;
                    case ConsoleKey.UpArrow: dir = "UP"; break;
                    case ConsoleKey.DownArrow: dir = "DOWN"; break;
                }
            }
        }

        void Logic()
        {
            int preX = TailX[0], preY = TailY[0];
            int tempX, tempY;

            if (dir != "STOP")
            {
                TailX[0] = headX; TailY[0] = headY; //them 1ptu
                for (int i = 1; i < nTail; i++)
                {   //0 i1 i2 i3 => (pre=0)  => 0 0 i1 i2 i3
                    tempX = TailX[i];
                    tempY = TailY[i]; //temp=i1
                    TailX[i] = preX;
                    TailY[i] = preY;  //i1= pre
                    preX = tempX;
                    preY = tempY;     //pre=i1
                }
            }

            switch (dir)
            {
                case "RIGHT": headX++; break;
                case "LEFT": headX--; break;
                case "UP": headY--; break;
                case "DOWN": headY++; break;
                case "STOP":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Game paused");
                            Console.WriteLine();
                            Console.WriteLine("      - Press key P to pause game            ");
                            Console.WriteLine("      - Press key R to reset game            ");
                            Console.WriteLine("      - Press key Q to quit game             ");

                            keypress = Console.ReadKey(true);
                            if (keypress.Key == ConsoleKey.Q)
                                Environment.Exit(0);
                            if (keypress.Key == ConsoleKey.R)
                            {
                                reset = true; break;
                            }
                            if (keypress.Key == ConsoleKey.P)
                                break;
                        }
                        dir = pre_dir; break;
                    }
            }
            //kiem tra va cham bien
            if (headX <= 0 || headX >= width - 1 || headY <= 0 || headY >= height - 1) gameOver = true;
            else gameOver = false;
            //kiem tra an qua
            if (headX == fruitX && headY == fruitY)
            {
                score += typeFruit; nTail++;
                randomQua();
            }
            //xac dinh chieu dang di chuyen con ran 
            if (((dir == "LEFT" && pre_dir != "UP") && (dir == "LEFT" && pre_dir != "DOWN")) || (
                (dir == "RIGHT" && pre_dir != "UP") && (dir == "RIGHT" && pre_dir != "DOWN")))
                horizontal = true;
            else horizontal = false;

            if (((dir == "UP" && pre_dir != "LEFT") && (dir == "UP" && pre_dir != "RIGHT")) || (
                (dir == "DOWN" && pre_dir != "LEFT") && (dir == "DOWN" && pre_dir != "RIGHT")))
                vertical = true;
            else vertical = false;

            //kiem tra thân con rắn
            for (int i = 1; i < nTail; i++)
            {
                //thân va chạm với đầu
                if (TailX[i] == headX && TailY[i] == headY)
                {
                    if (horizontal || vertical)
                        gameOver = false;
                    else
                        gameOver = true;
                }
                //quả trùng với thân con rắn  (phần lệnh //kiem tra an qua)
                if (TailX[i] == fruitX && TailY[i] == fruitY)
                    randomQua();
            }
        }
        //Xu ly khi THUA
        void Lose()
        {
            Console.WriteLine("YOU DIED");
            Console.WriteLine("Press R to Reset game");
            Console.WriteLine("Press Q to Quit game");
            while (true)
            {
                keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
                if (keypress.Key == ConsoleKey.R)
                {
                    reset = true; break;
                }
            }
        }

    }
}
