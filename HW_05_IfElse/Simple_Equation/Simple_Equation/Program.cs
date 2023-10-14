using System;

namespace Simple_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
           // int count = 3;

            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");

            tudau:
            Console.WriteLine("Input a: ");
            if (float.TryParse(Console.ReadLine(), out a)){
                Console.WriteLine("Input b: ");
                if (float.TryParse(Console.ReadLine(), out b)){
                    if (a != 0)
                    {
                        float result = -b / a;
                        Console.WriteLine("The result is: " + result);
                    }
                    else
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("The result is all x ");
                        }
                        else
                        {
                            Console.WriteLine("Nod soluiton");
                        }
                    }
                } else
                {
                        Console.WriteLine("Invalid input b");
                        goto tudau;
                }
            } else
            {
                    Console.WriteLine("Invalid input a");
                    goto tudau;
                }
            Console.ReadKey();
        }
    }
}
