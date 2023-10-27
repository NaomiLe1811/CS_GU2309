using System;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            Cau1(); //toan tu ba ngoi
            Cau2(); //cac loai loop
            Cau3(); //vi du for loop vs while vs foreach
            Cau4(); //nested for loop ly thuyet
            Cau5(); //phan biet value va index
            Cau6(); //bai tap nested for loop

        }

        static void Cau1()
        {
            // If-else statement example
            int x = 10;
            string result;
            if (x > 5)
            {
                result = "x is greater than 5";
            }
            else
            {
                result = "x is less than or equal to 5";
            }
            Console.WriteLine(result);

            // Ternary operation example
            int x = 10;
            string result = (x > 5) ? "x is greater than 5" : "x is less than or equal to 5";
            Console.WriteLine(result);

            ______________________________

            // If-else statement with multiple conditions
            int a = 10;
            int b = 5;
            string result;

            if (a > b)
            {
                result = "a is greater than b";
            }
            else if (a < b)
            {
                result = "a is less than b";
            }
            else
            {
                result = "a is equal to b";
            }
            Console.WriteLine(result);

            // Ternary operation with multiple conditions
            int a = 10;
            int b = 5;
            string result = (a > b) ? "a is greater than b" : (a < b) ? "a is less than b" : "a is equal to b";
            Console.WriteLine(result);

            ______________________________

            //formula //điều kiện ? kết quả đúng : kết quả sai
            condition? consequent : alternative

            n % 2 != 0 ? n * 2 : n

            //Ý nghĩa của biểu thức n % 2 != 0 ? n * 2 : n là:
            //Nếu phần dư của n chia cho 2 không bằng 0(tức là nếu n là một số lẻ), thì biểu thức sẽ đánh giá thành n *2.
            //Nếu phần dư của n chia cho 2 bằng 0(tức là nếu n là một số chẵn), thì biểu thức sẽ đánh giá thành n.
            //Nói cách khác, biểu thức này hiệu quả làm gấp đôi giá trị của n nếu nó là một số lẻ và giữ nguyên nếu nó là một số chẵn.
        }

        static void Cau2()
        {
            //co 4 loai loop chinh trong C#

           1.for loop: Executes a block of code a specified number of times.
           //Vòng lặp for: Sử dụng khi bạn cần thực hiện một khối mã một số lần xác định.Nó hữu ích khi bạn biết trước số lần lặp cụ thể.

            for (initialization; condition; iteration)
                {
                    // statements
                } 

           2.while loop: Executes a block of code as long as the specified condition is true.
            //Sử dụng khi bạn cần thực hiện một khối mã trong khi một điều kiện cụ thể đún. Dùng khi không biết nên lặp mấy lần.
                while (condition)
             {
                // statements
            }

            3. do -while loop: Similar to the while loop, but it executes the block of code at least once, and then repeatedly executes it as long as the specified condition is true.
                //Tương tự như vòng lặp while, nhưng nó thực hiện khối mã ít nhất một lần, sau đó lặp đi lặp lại khi điều kiện cụ thể vẫn đúng.
                do
            {
                // statements
            } while (condition);


            4. foreach loop: Iterates over elements of arrays or collections.
                //Sử dụng khi bạn cần lặp qua tất cả các phần tử trong mảng hoặc bộ sưu tập. Nó hữu ích khi bạn không cần quan tâm đến chỉ số của mỗi phần tử.
                foreach (var item in collection)
            {
                // statements
            }

             static void Cau3()
            {
                // Complicated for loop example
                int n = 5;
                int factorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Factorial of {n} is {factorial}");
                //ket qua la Factorial of 5 is 120
                /* 
                                    vong lap i (i<n)     vong lap Factorial       ket qua v1
              Bat dau tu                1             *           1           =       1
              Vong tiep theo 1   *      2                                     =       2
                             2   *      3                                     =       6
                             6   *      4                                     =       24
                             24  *      5                                     =       120 
                 */
                ______________________________

                // Complicated while loop example
                int target = 50;
                int sum = 0;
                int num = 1;
                while (sum < target)
                {
                    sum += num;
                    num++;
                }
                Console.WriteLine($"The sum of consecutive numbers up to {num - 1} is {sum}.");
                //The sum of consecutive numbers up to 10 is 55. Thuật toán này cơ bản là tính tổng của các số liên tiếp, bắt đầu từ 1, cho đến khi tổng vượt quá hoặc bằng giá trị mục tiêu là 50.

                /*
                        round          vong lap num        sum (sum = sum + num)
                          1                 1         +         0                   = 1
                          2                 2         +         1                   = 3
                          3                 3         +         3                   = 6
                          4                 4         +         6                   = 10
                          5                 5         +         10                  = 15
                          6                 6         +         15                  = 21
                          7                 7         +         21                  = 28
                          8                 8         +         28                  = 36
                          9                 9         +         36                  = 45
                          10                10        +         45                  = 55
                */
                ______________________________

                // Complicated foreach loop example
                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
                int product = 1;
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        product *= number;
                    }
                }
                Console.WriteLine($"Product of even numbers in the list: {product}");
                //Product of even numbers in the list: 8

                /* 

                 round          vong lap num      product (=product * number)
                   1                 1                   1                = 1 (num is not even)
                   2                 2         *         1                = 2 (pick)
                   3                 3                   2                = 2 (num is not even)
                   4                 4         *         2                = 8 (pick) => final result
                   5                 5         *         24               = 120 (num is not even)                 
                 */

            }

            static void Cau4()
            {
                for (int i = 0; i < outerLimit; i++)
                {
                    // Outer loop code
                    for (int j = 0; j < innerLimit; j++)
                    {
                        // Inner loop code
                    }
                }
                //Vòng lặp lồng nhau thường được sử dụng cho các nhiệm vụ như:

                //Duyệt qua một mảng 2D hoặc ma trận, trong đó vòng lặp bên ngoài di chuyển qua các hàng và vòng lặp bên trong di chuyển qua các cột.
                //Tạo bảng và lưới trong đó mỗi phần tử cần được xử lý.
                //Thực hiện các mẫu hoặc cấu trúc phức tạp yêu cầu nhiều cấp độ lặp.
            }

            static void Cau5()
            {

                int[] myArray = new int[] { 2, 3, 5, 3, 5, 7, 8, 9 };

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[2]); //in ra 5, phai them break
                    break;
                }
                Console.WriteLine();
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(i); //01234567 in index
                }
                Console.WriteLine();
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write(myArray[i]); //23535789 in value
                }
            }
            static void Cau6()
            {

            }
        }
    }
}
