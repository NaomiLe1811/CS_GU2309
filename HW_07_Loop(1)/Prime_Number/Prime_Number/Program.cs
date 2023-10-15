using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out number) && number < 2)
            {
                Console.WriteLine(number + " is not a prime numnber");
            }
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " is a prime");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime");
                }
            }

            Console.ReadKey();
        }
    }
}
