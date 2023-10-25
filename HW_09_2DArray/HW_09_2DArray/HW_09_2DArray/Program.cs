using System;
using System.Collections.Generic;


namespace HW_09_2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise1a1();
            Exercise1a2();
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
    }
}
