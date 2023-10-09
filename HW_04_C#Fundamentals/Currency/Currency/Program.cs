using System;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            /* float vndInput;
            float result_1;
            float usdInput;
            float result_2;
            int userInput;

            Console.WriteLine("Hi, if you want to exchange from vnd to usd, press 1. If you want to exchange from usd to vnd, press 2");

            if (!int.TryParse(Console.ReadLine(), out userInput) || (userInput != 1 && userInput != 2))
            {
                Console.WriteLine("Please enter 1 or 2");
            }
            else
            {
                if (userInput == 1)
                {
                    Console.WriteLine("Input your VN: ");
                    vndInput = int.Parse(Console.ReadLine());
                    result_1 = vndInput/23;
                    Console.WriteLine("ok now that is " + result_1);
                }
                else if(userInput == 2)
                {
                    Console.WriteLine("Input your USD: ");
                    usdInput = int.Parse(Console.ReadLine());
                    result_2 = usdInput * 23000;
                    Console.WriteLine("ok now that is " + result_2);
                }
            } */

            float vndInput;
            float result_1;
            float usdInput;
            float result_2;
            int userInput;

            Console.WriteLine("Hi, if you want to exchange from vnd to usd, press 1. If you want to exchange from usd to vnd, press 2");

            do
            {
                Console.WriteLine("Please enter 1 or 2");
            }
            while (!int.TryParse(Console.ReadLine(), out userInput) || (userInput != 1 && userInput != 2));

            if (userInput == 1)
            {
                Console.WriteLine("Input your VND: ");
                vndInput = int.Parse(Console.ReadLine());
                result_1 = vndInput / 23000;
                Console.WriteLine("ok now that is " + result_1 + " usd");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("Input your USD: ");
                usdInput = int.Parse(Console.ReadLine());
                result_2 = usdInput * 23000;
                Console.WriteLine("ok now that is " + result_2 + " vnd");
            }
            Console.ReadKey();
        }
    }
}
