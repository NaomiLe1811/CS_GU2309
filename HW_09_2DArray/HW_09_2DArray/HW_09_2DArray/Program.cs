using System;
using System.Collections.Generic;


namespace HW_09_2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1(); //create list and random nums
            //Exercise1a1(); //print diagonal elements
            //Exercise1a2(); //print opposite diagonal elements
            //Exercise1a3();  //print bottom left triangle
            //Exercise1a4(); //print bottom right, but errorr ...
            //Exercise2();
            Exercise2a1();
        }

        static void Exercise1()
        {
            Random random = new Random();
            List<List<int>> twoDList = new List<List<int>>();
            for(int i = 0;i < 5; i++)
            {
                List<int> row = new List<int>();
                for(int j = 0; j < 5; j++)
                {
                    int randomValue = random.Next(10, 31);
                    row.Add(randomValue);
                    Console.Write(randomValue + " ");
                }
                twoDList.Add(row);
                Console.WriteLine();
            }

        }
        static void Exercise1a1()
        {
            Random random = new Random();
            List<List<int>> twoDList = new List<List<int>>();
            for (int i = 0; i < 5; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    int randomValue = random.Next(10, 31);
                    row.Add(randomValue);
                    Console.Write(randomValue + " ");
                }
                twoDList.Add(row);
                Console.WriteLine();
            }

            Console.WriteLine("Diagonal Elements:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(twoDList[i][i] + " ");
            }

        }
        static void Exercise1a2()
        {
            Random random = new Random();
            List<List<int>> twoDList = new List<List<int>>();
            for (int i = 0; i < 5; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    int randomValue = random.Next(10, 31);
                    row.Add(randomValue);
                    Console.Write(randomValue + " ");
                }
                twoDList.Add(row);
                Console.WriteLine();
            }
            Console.WriteLine("Opposite diagonal Elements:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(twoDList[i][4-i] + " ");
            }
        }
        static void Exercise1a3()
        {
            Random random = new Random();
            List<List<int>> twoDList = new List<List<int>>();
            for (int i = 0; i < 5; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    int randomValue = random.Next(10, 31);
                    row.Add(randomValue);
                    Console.Write(randomValue + " ");
                }
                twoDList.Add(row);
                Console.WriteLine();
            }
            Console.WriteLine("Printing bottem left triangle:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(twoDList[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Exercise1a4()
        {
            Random random = new Random();
            List<List<int>> twoDList = new List<List<int>>();
            for (int i = 0; i < 5; i++)
            {
                List<int> row = new List<int>();
                for (int j = 0; j < 5; j++)
                {
                    int randomValue = random.Next(10, 31);
                    row.Add(randomValue);
                    Console.Write(randomValue + " ");
                }
                twoDList.Add(row);
                Console.WriteLine();
            }
            Console.WriteLine("Printing bottem right triangle:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(twoDList[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Exercise2()
        {
            Random random = new Random();
            List<List<int>> twoDList = new List<List<int>>();

            for (int i = 0; i < 5 * 5; i++)
            {
                int row = i / 5;
                int col = i % 5;
                int randomValue = random.Next(10, 31);
                if (twoDList.Count <= row)
                {
                    twoDList.Add(new List<int>());
                }
                twoDList[row].Add(randomValue);
                Console.Write(randomValue + " ");

                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void Exercise2a1()
        {
            Random random = new Random();
            int[,] twoDArray = new int[3, 3];

            for (int i = 0; i < 3 * 3; i++) //3 rows * 3 cols
            {
                int row = i / 3;
                int col = i % 3;
                int randomValue = random.Next(10, 31); 
                twoDArray[row, col] = randomValue;
                Console.Write(randomValue + " ");

                if ((i + 1) % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
