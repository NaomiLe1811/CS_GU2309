using System;

namespace Number_Spell_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            tudau:
            int input;
            Console.Write("Nhap input: ");
            Console.Write(" ");
            bool laso = int.TryParse(Console.ReadLine(), out input);

            if (laso)
            {
                int a = input / 100; // day la hang tram
                int b = (input / 10) % 10; // day la hang chuc
                int c = input % 10; // day la hang don vi
                //Console.WriteLine(a * 100 + b * 10 + c);
                // Neu so la 0 => in ra Zero
                if (input == 0)
                {
                    Console.WriteLine("Zero");
                    goto tudau;
                }
                switch (a) // kiem tra hang tram
                {
                    case 0: Console.Write(""); break;
                    case 1: Console.Write("One hundred "); break;
                    case 2: Console.Write("Two hundred "); break;
                    case 3: Console.Write("Three hundred "); break;
                    case 4: Console.Write("Four hundred "); break;
                    case 5: Console.Write("Five hundred "); break;
                    case 6: Console.Write("Six hundred "); break;
                    case 7: Console.Write("Seven hundred "); break;
                    case 8: Console.Write("Eight hundred "); break;
                    case 9: Console.Write("Nine hundred "); break;
                    default:
                        Console.WriteLine("Invalid number \n"); // neu so do >= 1000
                        goto tudau;
                }
                switch (b) // kiem tra hang chuc
                {
                    case 1: // tai vi so tu 11-19 la so dac biet
                        switch (c)
                        {
                            case 0: Console.Write("Ten "); break;
                            case 1: Console.Write("Eleven "); break;
                            case 2: Console.Write("Twelve "); break;
                            case 3: Console.Write("Thirdteen "); break;
                            case 4: Console.Write("Fourteen "); break;
                            case 5: Console.Write("Fifteen "); break;
                            case 6: Console.Write("Sixteen "); break;
                            case 7: Console.Write("Seventeen "); break;
                            case 8: Console.Write("Eighteen "); break;
                            case 9: Console.Write("Nineteen"); break;
                        }
                        Console.WriteLine("\n");
                        goto tudau;

                    case 2: Console.Write("Twenty "); break;
                    case 3: Console.Write("Thirty "); break;
                    case 4: Console.Write("Fourty "); break;
                    case 5: Console.Write("Fifty "); break;
                    case 6: Console.Write("Sixty "); break;
                    case 7: Console.Write("Seventy "); break;
                    case 8: Console.Write("Eighty "); break;
                    case 9: Console.Write("Ninety "); break;
                        //default: Console.WriteLine("Invalid number"); break;
                }
                switch (c)
                {
                    //case 0: Console.Write("Zero"); break;
                    case 1: Console.Write("One"); break;
                    case 2: Console.Write("Two"); break;
                    case 3: Console.Write("Three"); break;
                    case 4: Console.Write("Four"); break;
                    case 5: Console.Write("Five"); break;
                    case 6: Console.Write("Six"); break;
                    case 7: Console.Write("Seven"); break;
                    case 8: Console.Write("Eight"); break;
                    case 9: Console.Write("Nine"); break;
                        //default: Console.WriteLine("Invalid number"); break;
                }
                Console.WriteLine("\n");
                goto tudau;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input \n");
                goto tudau;
            }
        }
    }
}
