using System;

namespace HW_05_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
            Exercise5();
            Exercise6();
            Exercise7();
            Exercise8();
            Exercise9();

            Console.ReadLine();
        }

        static void Exercise1()
        {
            //Nhập vào 1 số và kiểm tra số đó có phải là số chẵn không? Xuất: yes hoặc no.
            int input;
            Console.WriteLine("Ex1: Input a number & check if it is an even numer");
        input_again:
            Console.WriteLine("Input your answer:");

            if ((int.TryParse(Console.ReadLine(), out input) && input % 2 == 0)) {
                Console.WriteLine("yes, it is even number");
            } else
            {
                Console.WriteLine("no, please input again");
                goto input_again;
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }

        static void Exercise2()
        {
            //Nhập vào 1 số và kiểm tra số đó có phải là số chính phương không? Xuất: yes hoặc no.
            int input;
            Console.WriteLine("Ex2: Input a number & check if it is a square number");
        input_again:
            Console.WriteLine("Input your answer:");

            if (int.TryParse(Console.ReadLine(), out input))
            {
                // Calculate the square root from input
                int sqr = (int)Math.Sqrt(input);

                // Check if the square root is an integer
                if (sqr * sqr == input) //vd input = 9 => sqr = 3 => 3*3=9 => input la so chinh phuong 
                {
                    Console.WriteLine("yes, it is a square number");
                }
                else
                {
                    Console.WriteLine("no, it is not a square number, please input again");
                    goto input_again;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please input again");
                goto input_again;
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }

        static void Exercise3()
        {
            // Nhập vào 3 sô nguyên a,b,c.Tìm sô lớn nhất và sô nhỏ nhất trong 3 số đó.
            int inputA, inputB, inputC;
            Console.WriteLine("Ex3: input 3 integer number, find the highest and smallest number");
        input_again1:
            Console.WriteLine("Input your first number");
            if (int.TryParse(Console.ReadLine(), out inputA)) {
            input_again2:
                Console.WriteLine("Input your second number");
                if (int.TryParse(Console.ReadLine(), out inputB)) {
                input_again3:
                    Console.WriteLine("Input your third number");
                    if (int.TryParse(Console.ReadLine(), out inputC)) {
                        Console.WriteLine("they are all interger");
                        //
                        if (inputA > inputB && inputA > inputC && inputB > inputC) //case1
                        {
                            Console.WriteLine(inputA + " is the hightest number");
                            Console.WriteLine(inputC + " is the smallest number");
                        }
                        if (inputA > inputB && inputA > inputC && inputC > inputB) //case2
                        {
                            Console.WriteLine(inputA + " is the hightest number");
                            Console.WriteLine(inputB + " is the smallest number");
                        }
                        if (inputB > inputC && inputB > inputA && inputC > inputA) //case3
                        {
                            Console.WriteLine(inputB + " is the hightest number");
                            Console.WriteLine(inputA + " is the smallest number");
                        }
                        if (inputB > inputC && inputB > inputA && inputA > inputC) //case4
                        {
                            Console.WriteLine(inputB + " is the hightest number");
                            Console.WriteLine(inputC + " is the smallest number");
                        }
                        if (inputC > inputA && inputC > inputB && inputB > inputA) //case5
                        {
                            Console.WriteLine(inputC + " is the hightest number");
                            Console.WriteLine(inputA + " is the smallest number");
                        }
                        if (inputC > inputA && inputC > inputB && inputA > inputB) //case6
                        {
                            Console.WriteLine(inputC + " is the hightest number");
                            Console.WriteLine(inputB + " is the smallest number"); 
                        } // still more 3 case 
                    }
                    else
                    {
                        Console.WriteLine("Invalid first input, please try again");
                        goto input_again3;
                    }
                } else
                {
                    Console.WriteLine("Invalid first input, please try again");
                    goto input_again2;
                }
            } else
            {
                Console.WriteLine("Invalid first input, please try again");
                goto input_again1;
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }

        static void Exercise4()
        {
            //Nhập vào 2 số nguyên và 1 phép toán. Yêu cầu xuất ra kết quả phép tính dựa trên phép toán(là 1 trong 4 phép toán: +,-,*,%)
            int a, b;
        again:
            Console.WriteLine("Ex4: Input 2 integer number to caculate a + b");
            if (int.TryParse(Console.ReadLine(), out a))
            {

                if (int.TryParse(Console.ReadLine(), out b))
                {
                    int c = a + b;
                    Console.WriteLine("The result is: " + c);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    goto again;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
                goto again;
            }

            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }

        static void Exercise5()
        {
            //Giải phương trình Ax +B = 0.Với A, B là hệ sô được nhập vào từ bàn phím (Solve the equation Ax + B = 0, where A and B are entered from the keyboard.)
            //• Nếu phương trình vô nghiệm xuất kết quả: VN If the equation has no solution, output the result: "No solution" (VN).
            //• Nếu phương trình VSN xuất ra : VSN If the equation has infinitely many solutions, output: "Infinite solutions" (VSN).
            //• Nếu phương có nghiệm, xuất ra nghiệm(Lưu ý: lấy 2 chữ số thập phân If the equation has a solution, output the solution (Note: rounded to two decimal places).

            float A, B;

        again:
            Console.WriteLine("Ex5: Ax + B = 0, find x that A and B are entered from the keyboard");
            if (float.TryParse(Console.ReadLine(), out A))
            {
                if (float.TryParse(Console.ReadLine(), out B))
                {
                    /*if(A == 0 || B == 0)
                    {
                        Console.WriteLine("Vo nghiem");
                    }
                    else if( A == 0 && B == 0)
                    {
                        Console.WriteLine("Vo so nghiem");
                    }*/

                    if (A == 0)
                    {
                        if (B == 0)
                        {
                            Console.WriteLine("Chuong trinh vo so nghiem");
                        }
                        else
                        {
                            Console.WriteLine("Chuong trinh vo nghiem");
                        }
                    }
                    else {
                        float result = -B / A;
                        Console.WriteLine("x is: " + result);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again");
                    goto again;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please try again");
                goto again;
            }

            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }
        static void Exercise6()
        {
            //Nhập vào 1 số nguyên là tháng. Xuất ra số ngày trong tháng đó. Lưu ý: tháng 2 mặc định lấy 28 ngày.
            Console.WriteLine("Ex6:Enter an integer as a month. Output the number of days in that month. Note: February defaults to 28 days.");
            Console.WriteLine("Input your answer");
            int month;
            if ((int.TryParse(Console.ReadLine(), out month) && month > 0 && month < 13)) {

                int dayInMonth = GetDaysInMonth(month);
                Console.WriteLine("Days in this month is: " + dayInMonth);
            }
            else
            {
                Console.WriteLine("Invalid month");
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }
        static int GetDaysInMonth(int month)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return 28;
                default:
                    if (month >= 1 && month <= 12)
                    {
                        return 31;
                    }
                    else
                    {
                        return -1;
                    }
            }
        }

        static void Exercise7()
        {
            //Nhập vào 2 số nguyên là tháng và năm. Xuất ra chính xác số ngày trong tháng đó.Lưu ý kiểm tra năm nhuận cho tháng 2.
            Console.WriteLine("Ex7:Enter two integers, one for the month and one for the year. Output the exact number of days in that month, considering leap years for February.");
            int month;
            int year;
            if (int.TryParse(Console.ReadLine(), out month) && month > 0 && month < 13)
            {
                Console.WriteLine("Enter an integer for the year:");
                if (int.TryParse(Console.ReadLine(), out year))
                {
                    int daysInMonth = tinhNamNhuan(month, year);
                    if (daysInMonth > 0 && daysInMonth < 13)
                    {
                        Console.WriteLine("The number of days in month" + month + " of" + year + " is" + daysInMonth);
                    }
                    else
                    {
                        Console.WriteLine("Invalid month or year. Please check your input.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the year. Please enter a valid integer.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for the month. Please enter a month between 1 and 12.");
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }

        static int tinhNamNhuan(int month, int year)
        {
            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    if (IsLeapYear(year))
                    {
                        return 29; // February in a leap year has 29 days
                    }
                    else
                    {
                        return 28; // February in a non-leap year has 28 days
                    }
                default:
                    return 31; // All other months have 31 days
            }
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }

        static void Exercise8()
        {
            //Nhập vào 1 số gồm 4 chữ số abcd, yêu cầu tính tổng của: ad + bc = ??.Ví dụ: 1234 thì kết quả 14 + 23 = 37
            Console.WriteLine("Ex8:Enter a 4-digit number, represented as abcd, and calculate the sum of: ad + bc = ??.For example, if you input 1234, the result would be 14 + 23 = 37");
            Console.WriteLine("Enter your input ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 1000 && number <= 9999)
            {
                //vd: co so 4362, tong se la 4 va 2 va 6 va 2, a va d + b va c, nghia la a*d + b*c
                //hint: tat ca cac input chay tu 1000 den 9999
                //a va d nam o don vi chuc, nen a phai chia cho 1000
                //b va c nam o don vi ..., nen phai chia them cho 10 de vo expresion la du
                //a (giá trị hàng nghìn) = 4362 / 1000 = 4 (a (giá trị hàng nghìn) có thể lấy bằng cách chia số cho 1000.)
                //b (giá trị hàng trăm) = (4362 / 100) % 10 = (43) % 10 = 3 (b (giá trị hàng trăm) có thể lấy bằng cách chia số cho 100 rồi lấy phần dư khi chia cho 10.)
                //c (giá trị hàng chục) = (4362 / 10) % 10 = (436) % 10 = 6 (c (giá trị hàng chục) có thể lấy bằng cách chia số cho 10 rồi lấy phần dư khi chia cho 10.)
                //d (giá trị hàng đơn vị) = 4362 % 10 = 2 (d (giá trị hàng đơn vị) có thể lấy bằng cách chia số cho 10.)
                //result is a = 4, b = 3, c = 6, và d = 2 

                int a = number / 1000;       // Extract the thousands digit 1234 1.234
                int b = (number % 1000)/100;  // Extract the hundreds digit 1234 1.234
                int c = (number / 10)%10;    // Extract the tens digit 1234 12.34
                int d = number / 1000;       // Extract the ones digit 1234 123.4

                int result = (a * 10 + d) + (b * 10 + c); // Calculate ad + bc 

                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid 4-digit number.");
            }
            Console.WriteLine("Now move to the next exercise");
            Console.WriteLine("_______________________________");
            Console.WriteLine(" ");
        }

        static void Exercise9()
        {
            //[GIO_PHUT_GIAY] Nhập vào giờ, phút, giây. Kiểm tra giờ, phút, giây đó có hợp lệ hay không, nếu hợp lệ hãy cho bi giờ sau đó 1 giây là bao nhiêu?
            //• Dữ liệu vào: 3 số nguyên lần lượt là giờ, phút, giây.
            //• Dữ liệu ra:
            //• Dòng đầu xuất "YES" nếu hợp lệ, ngược lại xuất "NO" nếu không hợp lệ.
            //• Dòng thứ hai xuất giờ sau đó 1 giây nếu hợp lệ.

            int gio;
            int phut;
            int giay;

            Console.WriteLine("Ex9: Input gio, phut, giay as below");

            Console.WriteLine("Enter hours:");
            if (int.TryParse(Console.ReadLine(), out gio) && gio >= 0 && gio <= 23)
            {
                Console.WriteLine("Enter minutes:");
                if (int.TryParse(Console.ReadLine(), out phut) && phut >= 0 && phut <= 59)
                {
                    Console.WriteLine("Enter seconds:");
                    if (int.TryParse(Console.ReadLine(), out giay) && giay >= 0 && giay <= 59)
                    {
                        Console.WriteLine("YES");
                        giay++;
                        if (giay == 60)
                        {
                            giay = 0;
                            phut = phut + 1;
                            if (phut == 60)
                            {
                                phut = 0;
                                gio = gio + 1;
                                if (gio == 24)
                                {
                                    gio = 0;
                                }
                            }
                        }
                        Console.WriteLine("Gio la: " + gio + " phut la: " + phut + " giay la: " + giay);
                    }
                    else
                    {
                        Console.WriteLine("NO"); // Seconds input is invalid
                    }
                }
                else
                {
                    Console.WriteLine("NO"); // Minutes input is invalid
                }
            }
            else
            {
                Console.WriteLine("NO"); // Hours input is invalid
            }

        }

    }
}
