using System;

namespace Animal
{
    // Abstract base class 'Animal'
    public abstract class Animal
    {
        // Protected fields for weight and height
        protected string Weight { get; set; }
        protected string Height { get; set; }

        // Constructor for initializing weight and height
        public Animal(string weight, string height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        // Abstract method for printing information (to be implemented by derived classes)
        public abstract void PrintInfo();
    }

    // Derived class 'Cat' inheriting from 'Animal'
    class Cat : Animal
    {
        // Private field for cat's name
        private string Name { get; set; }

        // Constructor for initializing weight, height, and name
        public Cat(string weight, string height, string name) : base(weight, height)
        {
            this.Name = name;
        }

        // Implementation of the abstract method to print cat information
        public override void PrintInfo()
        {
            Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the 'Cat' class
            Cat cat = new Cat("20kg", "1.5", "Kitty");

            // Call the 'PrintInfo' method on the 'cat' object
            cat.PrintInfo();
        }
    }
}