using System;

namespace Shape_Performance
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Menu");
            Console.WriteLine("1. Print the rectangle");
            Console.WriteLine("2. Print the square triangle");
            Console.WriteLine("3. Print isosceles triangle");
            Console.WriteLine("4. Exit");

            choice = short.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("* * * * * * *");
                    Console.WriteLine("* * * * * * *");
                    Console.WriteLine("* * * * * * *");
                    break;

                case 2:
                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();

                    for (int i = 4; i >= 0; i--)
                    {
                        for (int j = i; j >= 0; j--)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }

                    int height = 5;

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < height - 1 - i; j++)
                        {
                            Console.Write("  ");
                        }

                        for (int k = 0; k <= i; k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }

                    for (int i = 0; i > height; i--)
                    {
                        for (int j = i; j < height + 1 + i; j++)
                        {
                            Console.Write("  ");
                        }

                        for (int k = 0; k <= i; k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("  ");
                        }
                        for (int k = 0; k < height - i; k++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    for (int i = 7; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
    }
}
