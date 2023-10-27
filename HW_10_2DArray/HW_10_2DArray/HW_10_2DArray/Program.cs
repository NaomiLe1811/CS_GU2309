using System;

namespace HW_10_2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many rows u want?");
            int input = int.Parse(Console.ReadLine());

            int[,] myArray = new int[,] { };

            // Populate the array
            for (int i = 0; i <= input; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i, j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            123      123
            456      234
            789      567

            111
            222
            333

        }
    }
}
