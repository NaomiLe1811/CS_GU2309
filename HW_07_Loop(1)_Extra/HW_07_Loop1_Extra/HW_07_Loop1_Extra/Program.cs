﻿using System;

namespace HW_07_Loop1_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            //Exercise5();
            //Exercise6();
            Exercise7();

            Console.ReadKey();
        }

        static void Exercise1()
        {
            //Nhập số nguyên A và kiểm tra xem A có phải là số nguyên tố hay không ?
            //tai sao phai dung loop trong khi i > 1
            int number;
        again:
            Console.WriteLine("Enter a prime number: ");

            if (int.TryParse(Console.ReadLine(), out number) && number < 2)
            {
                Console.WriteLine(number + " is not a valid numnber");
                Console.WriteLine("Please enter again");
                goto again;
            }
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false; //what if cho nay la check
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " is a prime number");
                }
                else
                {
                    Console.WriteLine(number + " is not a prime number");
                    Console.WriteLine("Please enter again");
                    goto again;
                }
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }

        static void Exercise2()
        {
            //In ra tất cả số chẵn trong khoảng(M, N). Với N, M nhập từ bàn phím.
            int inputN;
            int inputM;

        again:
            Console.WriteLine("Print numbers from your input and last input");
            Console.WriteLine("Enter your first input");
            if (int.TryParse(Console.ReadLine(), out inputN))
            {
                Console.WriteLine("Enter your second input");
                if (int.TryParse(Console.ReadLine(), out inputM))
                {
                    for (int i = inputN; i <= inputM; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i + " "); //sao cu xuong dong quai z
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number, please enter again");
                    goto again;
                }
            }
            else
            {
                Console.WriteLine("Invalid number, please enter again");
            }

            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }
        static void Exercise3()
        {
            //Nhập vào 1 số nguyên và xuất là Yes nếu nó là số hoàn hảo, ngược lại xuất No. Gợi ý: số hoàn hảo là số mà tổng ước số của nó(không tính nó) bằng chính nó.
            int input; //bug, lan 2 xuat ra nluon bi loi
            int sum = 0;
        again:
            Console.WriteLine("Enter your input to check perfect number: ");
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input <= 0)
                {
                    Console.WriteLine("Invalid number, please try again");
                    goto again;
                }

                for (int i = 1; i < input; i++)
                {
                    if (input % i == 0)
                    {
                        sum += i;
                    }
                }

                if (input == sum)
                {
                    Console.WriteLine(input + " is a perfect number");
                }
                else
                {
                    Console.WriteLine(input + " is not a perfect number");
                    Console.WriteLine("Please try again");
                    goto again;
                }
            }
            else
            {
                Console.WriteLine("Invalid number, please try again");
                goto again;
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }
        static void Exercise4()
        {   //Nhập vào 2 số nguyên a và b. Yêu cầu tìm UCLN của 2 số đó.

            int a; //chua hieu cong thuc, xem lai
            int b;
            //int gcd;
        again:
            Console.WriteLine("Find greatest common divisor");
            Console.WriteLine("Enter your first input");
            if (int.TryParse(Console.ReadLine(), out a) && a > 0)
            {
                Console.WriteLine("Enter your second input");
                if (int.TryParse(Console.ReadLine(), out b) && b > 0)
                {
                    a = Math.Abs(a);
                    b = Math.Abs(b);
                    while (b != 0)
                    {
                        int temp = b;
                        b = a % b;
                        a = temp;
                    }
                    Console.WriteLine("GCD is " + a);

                }
                else
                {
                    Console.WriteLine("Please enter valid input != 0");
                    goto again;
                }
            }
            else
            {
                Console.WriteLine("Please enter valid input != 0");
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }
        static void Exercise5()
        {
            //Nhập vào 1 số nguyên n, xuất ra n!
            int n;
            int sum = 1;
            Console.WriteLine("Enter n to print !n");
            again:
            Console.WriteLine("Enter your input");
            if(int.TryParse(Console.ReadLine(), out n))
            {
                int i;
                for(i = 1; i <= n; i++)
                {
                    sum = sum * i;
                }
                Console.WriteLine(sum);
                Console.Write(" ");
            } else
            {
                Console.WriteLine("Please enter valid input != 0");
                goto again;
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }
        static void Exercise6()
        {
            //Nhập vào số i, yêu cầu xuất ra bảng cửu chương thứ i
            int input;
            Console.WriteLine("Multiplication table");
        again:
            Console.WriteLine("Enter your input");
            if ((int.TryParse(Console.ReadLine(), out input ) && input >= 1 && input <= 10)){
                Console.WriteLine(input);
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(input + " * " + i + "=" + (input * i));
                }
            } else
            {
                Console.WriteLine("Please enter valid input from 1 to 10");
                goto again;
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }
        static void Exercise7()
        {
            // In ra bảng cửu chương từ 2 tới 10 khi nhấn phím Space
            int number = 2;
            Console.WriteLine("Press the Spacebar to view the multiplication table from 2 to 10");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine();
                    for (int i = 2; i <= 10; i++)
                    {
                        Console.WriteLine("Multiplication table for " + i);
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine(i + " * " + j + " = " + (i * j));
                        }
                        Console.WriteLine(); // Add a line for separation between tables
                    }
                    break;
                }
                Console.WriteLine("\nPlease press the Spacebar to view the multiplication table");
            }
        }
    }
}
