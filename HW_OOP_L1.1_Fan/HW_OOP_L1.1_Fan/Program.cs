using System;

namespace HW_OOP_L1._1_Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(3, true, "white");
            fan1.Display();

            Fan fan2 = new Fan(1, false, "red");
            fan2.Display();

            Fan fan3 = new Fan(3, true, "yellow", 10.0);
            Console.WriteLine("Fan 3:" + fan3.ToString());

            Fan fan4 = new Fan(2, false, "blue", 5);
            Console.WriteLine("Fan 4:" + fan4.ToString());

            Console.ReadKey();
        }
    }
}
