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
            //Exercise4(); //xoa phan tu khoi mang, co method
            //Exercise5(); //xoa tat ca element cung value
            //Exercise6();//in nhieu min nho nhat
            Exercise7();//phương thức đếm số lần xuất hiện của ký tự trong chuỗi

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
            again:
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
                    goto again;
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

        static void Exercise5()
        {
            List<int> list = new List<int> { 3, 7, 9, 1, 2, 6, 2, 4, 5, 7 };
            deleteSameElement(list);
        }

        public static void deleteSameElement(List<int> sameElement)
        {
            Console.WriteLine("Here we have a list");
            int i;
            for( i = 0; i < sameElement.Count; i++)
            {
                Console.Write(sameElement[i] + " ");
            }
            Console.WriteLine("which number you want to delete?");
            int deleteNum = int.Parse(Console.ReadLine());
            int index = sameElement.IndexOf(deleteNum);
            sameElement.RemoveAll((x => x == deleteNum)); //RemoveAll method expects a predicate to determine which elements to remove from the list. It doesn't take the element itself as an argument. 
            foreach (var item in sameElement)
            {
                
                Console.Write(item + " ");
            }
        }


        static void Exercise6()
       {
            int size = 10; //Set the desired size of the list
            List<int> randomList = new List<int>();
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                randomList.Add(random.Next(20)); // Adjust the upper limit as needed
            }
            // Call the MinValue2 method with the generated random list
            MinValue2(randomList);
       }
       public static void MinValue2(List<int> list)
       {
           int min = list[0]; 
           int index = 0;
            //indexes.Clear()
            Console.WriteLine("We have a list");
            foreach(var item in list)
            {
                Console.Write(item + " ");              
            }
            Console.Write("\n");
            Console.WriteLine("Min number is the list is: ");

            for (int i = 1; i < list.Count; i++) //i = 0 thi co duoc ko?
           {
               if(list[i] < min) //tìm giá trị min mới, reset list
                {
                   min = list[i];
                   index = i;
                   //2 lenh
                   list.Clear(); //xoa' cac element dang luu trong list (indexes)
                   list.Add(i);
                   list.Add(0);
                    Console.WriteLine($"The smallest number is {min} with the position {index} in the array");
                }
               else if (list[i] == min)
               {
                   //1 lenh
                   list.Add(i);
                    //Console.WriteLine($"The smallest number is {min} with the position {index} in the array");
                } 
           }
       }

        static void Exercise7()
        {
  
            Console.WriteLine("input a string: "); //step 1: create a string
            string name = Console.ReadLine();
            Console.WriteLine("Enter a character to count in the string: "); //step 2:ask a char user wants to count
            char inputChar = Console.ReadLine()[0]; // Read the first character of the input

            counting(name, inputChar);

        }

        public static void counting(string name, char inputChar)
        {
            int count = 0;
            for(int i = 0; i < name.Length; i++) //dem ky tu trung lap
            {
                if(name[i] == inputChar)
                {
                    count++;
                }                
            }
            if (count == 0)
                Console.WriteLine("Cannot find the letter");
            else //in ra (de ben ngoai de ko bi lap)
                Console.WriteLine($"The letter {name} appears {count} times");
        }
    }
}
