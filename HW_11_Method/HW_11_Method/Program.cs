using System;

namespace HW_11_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1(); //C -> F && F -> C
            //Exercise2(); //Tim min
            Exercise3(); //xoa phan tu khoi mang

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

        static void Exercise2()
        {
            int[] arr = { 4, 12, 7, 8, 17, 6, 9 };
            Console.WriteLine("Find the min number in the array");
            Minvalue(arr);

        }
        public static int Minvalue(int[] array)
        {
            int min = array[0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] < min)
                {
                    min = array[i];

                }
            } 
            Console.WriteLine($"The smallest number is {min} with the position {index} in the array");
            return index;
        }

        static void Exercise3()
        {
            int[] arr = { 4, 12, 7, 8, 17, 6, 9 };
            Console.WriteLine("Given array");
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("Which position you want to delete?");
            int input = int.Parse(Console.ReadLine());

            int index = -1;
            
            /*for(i = 0; i < arr.Length; i++)
            {
                if (input.Equals(arr[i]){
                    index = 1;
                    break;
                }
            }*/
            if (arr[i] == input)
            {
                Console.WriteLine($"The input { input} is at position { i} in the array.");
                for (int j = i; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                Array.Resize(ref arr, arr.Length - 1); // Resizing the array to remove the last element
                //break;

            }
            else
            {
                Console.WriteLine("Could not find");
            }

        }
    }
}
