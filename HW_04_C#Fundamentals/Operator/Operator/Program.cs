using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;
            int area;

            Console.WriteLine("Please input the width: ");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the height: ");
            height = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of this retangle is: ");
            area = width * height;
            Console.WriteLine(area);

            Console.ReadKey();
        }
    }
}
