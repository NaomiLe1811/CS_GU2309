using System;

namespace HW_11_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
        }

        static void Exercise1()
        {
            //double fahrenheit;
            //double celsius;
            int choice;
            int luot_dem = 3;

            again:
            Console.WriteLine("Menu.");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");

            if(!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2 && choice != 0))
            {
                Console.WriteLine(" Please input 1 or 2 or 0");
                luot_dem--;
                if(luot_dem == 0)
                {
                    Console.WriteLine("Out of turn, try again");
                    return; //to cover the luot_dem
                }
                goto again;               
            } else
            switch(choice)
            {
                 case 1:
                    FahrenheitToCelsius(choice);
                    break;
                case 2:
                    CelsiusToFahrenheit(choice);
                    break;
                case 0:
                    Console.WriteLine("Exiting the program.");
                break;
                default:
                    break;
            }
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            Console.WriteLine("Input the num that you want to convert");
            double celsius = int.Parse(Console.ReadLine());
            celsius = (5.0 / 9) * (fahrenheit - 32);          
            Console.WriteLine(celsius);
            return celsius;
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            Console.WriteLine("Input the num that you want to convert");
            double fahrenheit = int.Parse(Console.ReadLine());
            fahrenheit = (9.0 / 5) * celsius + 32;          
            Console.WriteLine(fahrenheit);
            return fahrenheit;
        }

    }
}
