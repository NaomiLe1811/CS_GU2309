using System;

// Step 1: Define a Class

// Class declaration
public class Animal
{
    // Fields (data members)
    public string Name;
    public int Age;

    // Constructor (Thuộc tính)
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Methods (Phương thức)
    public void MakeSound()
    {
        Console.WriteLine("Generic animal sound");
    }
}

// Step 2: Create Objects

class Program
{
    static void Main()
    {
        // Step 3: Create Objects from the Class

        // Create an instance of the Animal class
        Animal myAnimal = new Animal("Buddy", 3);

        // Step 4: Access Members and Methods

        // Access fields
        Console.WriteLine($"Name: {myAnimal.Name}, Age: {myAnimal.Age}");

        // Call methods
        myAnimal.MakeSound();

        // Step 5: Inheritance

        // Create a derived class
        Dog myDog = new Dog("Fido", 2, "Brown");

        // Access fields and methods from the base class
        Console.WriteLine($"Dog Name: {myDog.Name}, Age: {myDog.Age}, Color: {myDog.Color}");
        myDog.MakeSound();

        // Step 6: Polymorphism

        // Polymorphic behavior using a base class reference
        Animal polyAnimal = new Dog("Max", 1, "Black");
        polyAnimal.MakeSound(); // Outputs the dog's sound, not the generic animal sound
    }
}

// Step 7: Inheritance

// Derived class
public class Dog : Animal
{
    // Additional fields
    public string Color;

    // Constructor that calls the base class constructor
    public Dog(string name, int age, string color) : base(name, age)
    {
        Color = color;
    }

    // Override the MakeSound method from the base class
    public override void MakeSound()
    {
        Console.WriteLine("Bark! Bark!");
    }
}