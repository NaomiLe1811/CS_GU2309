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
        // Tạo một mảng các đối tượng Animal, bao gồm cả Dog và Cat
        Animal[] animals = new Animal[]
        {
            new Dog(),
            new Cat()
        };

        // Gọi phương thức MakeSound trên từng đối tượng trong mảng
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}

Trong ví dụ này, Animal là lớp cơ sở, và Dog và Cat là các lớp con kế thừa từ Animal. Mỗi lớp con triển khai lại phương thức MakeSound() theo cách của riêng nó. Trong Main(), chúng ta tạo một mảng của các đối tượng Animal, nhưng thực sự mỗi phần tử trong mảng có thể là một đối tượng của lớp con (Dog hoặc Cat). Khi gọi phương thức MakeSound() trên mỗi đối tượng trong mảng, phương thức tương ứng của lớp con được gọi, thể hiện tính chất đa hình.