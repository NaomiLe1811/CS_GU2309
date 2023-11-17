using System;

// Định nghĩa một giao diện có một phương thức MakeSound
public interface IAnimal
{
    void MakeSound();
}

// Lớp cha Animal triển khai giao diện IAnimal
public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Lớp con Dog kế thừa từ lớp Animal và triển khai lại phương thức MakeSound
public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Lớp con Cat kế thừa từ lớp Animal và triển khai lại phương thức MakeSound
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        // Tạo một mảng các đối tượng Animal, bao gồm cả Dog và Cat(tạo array)
        Animal[] animals = new Animal[]
        {
            new Dog(),
            new Cat()
        };

        // Gọi phương thức MakeSound trên từng đối tượng trong mảng (loop để đi qua các phần tử trong array)
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}