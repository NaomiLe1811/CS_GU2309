using System;

namespace Animal
{
    public class Cat
    {
        private string Weight { get; set; }
        private string Height { get; set; }
        private string Name { get; set; }

        public Cat(string weight, string height, string name)
        {
            this.Weight = weight;
            this.Height = height;
            this.Name = name;
        }

        // Phương thức không sử dụng override
        public void PrintInfoWithoutOverride()
        {
            // Hiển thị thông tin mèo trực tiếp bằng Console.WriteLine
            Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weight, this.Height, this.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5", "Kitty");

            // Gọi phương thức không sử dụng override
            cat.PrintInfoWithoutOverride();
        }
    }
}