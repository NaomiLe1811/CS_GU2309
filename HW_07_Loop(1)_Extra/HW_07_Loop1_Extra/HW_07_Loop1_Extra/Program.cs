using System;

namespace HW_07_Loop1_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();

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
            int input;
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
    }
}
