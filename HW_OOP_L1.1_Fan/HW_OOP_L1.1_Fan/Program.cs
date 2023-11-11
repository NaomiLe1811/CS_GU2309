using System;

namespace HW_OOP_L1._1_Fan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(3, true, "white");
            fan1.Display();

            Fan fan2 = new Fan(1, false, "yellow");
            fan2.Display();
        }
    }
}
