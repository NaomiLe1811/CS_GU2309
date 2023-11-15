using System;

namespace HW_13_OOP_Circle_Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(6, "Blue");
            Cylinder cylinder = new Cylinder(10, "Red", 8);

            Console.WriteLine(circle);
            Console.WriteLine(cylinder);
            Console.WriteLine(cylinder.TheTich());

            Console.ReadKey();
        }
    }
}
