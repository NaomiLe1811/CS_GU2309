using System;

namespace HW_12_OOP_Animal_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());

                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.HowToEat());
                }
            }

            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            Console.ReadKey();
        }
    }
}
