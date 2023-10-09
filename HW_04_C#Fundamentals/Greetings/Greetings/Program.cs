using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Hi! What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name);

            Console.ReadKey();
        }
    }
}
