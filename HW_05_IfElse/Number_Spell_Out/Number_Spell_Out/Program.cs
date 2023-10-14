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
                int a = input / 100;
                int b = (input / 10) % 10;
                int c = input % 10;
                //Console.WriteLine(a * 100 + b * 10 + c);

                switch (a)
                {
                    case 1: Console.Write("One hundred"); break;
                    case 2: Console.Write("Two hundred"); break;
                    case 3: Console.Write("Three hundred"); break;
                    case 4: Console.Write("Four hundred"); break;
                    case 5: Console.Write("Five hundred"); break;
                    case 6: Console.Write("Six hundred"); break;
                    case 7: Console.Write("Seven hundred"); break;
                    case 8: Console.Write("Eight hundred"); break;
                    case 9: Console.Write("Nine hundred"); break;
                    //default: Console.WriteLine("Invalid number"); break;
                }
                switch (b)
                {
                    case 1: Console.Write("Ten"); break;
                    case 2: Console.Write("Twenty"); break;
                    case 3: Console.Write("Thirty"); break;
                    case 4: Console.Write("Fourty"); break;
                    case 5: Console.Write("Fifhty"); break;
                    case 6: Console.Write("Sixty"); break;
                    case 7: Console.Write("Seventy"); break;
                    case 8: Console.Write("Eighty"); break;
                    case 9: Console.Write("Ninety"); break;
                    //default: Console.WriteLine("Invalid number"); break;
                }
                switch (c)
                {
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
        }
    }
}
