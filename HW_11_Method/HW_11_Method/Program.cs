using System;
using System.Collections.Generic;

namespace HW_11_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1(); //C -> F && F -> C
            //Exercise2(); //Tim min
            //Exercise3(); //xoa phan tu khoi mang, ko co method
            Exercise4(); //xoa phan tu khoi mang co method
            //Exercise5();//in nhieu min nho nhat

            Console.ReadKey();

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
            List<int> list = new List<int> { 4, 12, 7, 8, 17, 6, 9 };

            Console.WriteLine("Given array");
            int i;
            //in mang cho de nhin
            for (i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("Which position you want to delete?");
            int delete = int.Parse(Console.ReadLine());
            int index = list.IndexOf(delete);//tra value cua index dau tien

            if (delete != -1) 
            {
                Console.WriteLine($"The input {delete} is at position {index} in the list.");
                list.RemoveAt(index);
                Console.WriteLine("List after deletion:");
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Could not find the element in the list.");
            }
        }

        static void Exercise4()
        {
            List<int> list = new List<int> { 2, 7, 8, 2, 2, 6, 4, 5 };
            deleteElement(list);

        }

        public static void deleteElement(List<int> list)
        {
            Console.WriteLine("Here we have the array");
            int i;
            for(i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("Which element you want to delete?");
            int delete = int.Parse(Console.ReadLine());
            int index = list.IndexOf(delete);

            if (list.Contains(delete))
            {
                Console.WriteLine($"Your input {delete} is in the list");
                list.Remove(delete);
                Console.WriteLine("Now your list is");
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Cannot find the element in the list");
            }
        }


        /*static void Exercise5()
       {
           int[] array = { 1, 2, 3, 1, 4, 1 };
           List<int> minIndexes = MinValue2(array);
       }
       public static List<int> MinValue2(List<int> list)
       {
           int min = array[0]; 
           int index = 0;
           //indexes.Clear()

           for (int i = 1; i < array.Count; i++) //i = 0 thi co duoc ko?
           {
               if(array[i] < min)
               {
                   min = array[i];
                   index = i;
                   //2 lenh
                   list.Clear(); //xoa' cac element dang luu trong list (indexes)
                   list.Add(i);
                   list.Add(0);
               }
               else if (array[i] == min)
               {
                   //1 lenh
                   list.Add(i);
               } 
           }
       } */
    }
}
