using System;

class Animal
{
    // Properties (data members)
    public string Name { get; set; }
    public string Sound { get; set; }

    // Constructor
    public Animal(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }

    // Method to make the animal sound
    public void MakeSound()
    {
        Console.WriteLine($"{Name} says {Sound}!");
    }

    // Method to simulate the animal's movement
    public void Move()
    {
        Console.WriteLine($"{Name} is moving.");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of the 'Animal' class
        Animal dog = new Animal("Dog", "Woof");
        Animal cat = new Animal("Cat", "Meow");

        // Call methods on the 'dog' object
        dog.MakeSound();
        dog.Move();

        // Call methods on the 'cat' object
        cat.MakeSound();
        cat.Move();
    }
}