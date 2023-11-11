using System;

namespace Animal
{
    // Lớp cơ sở trừu tượng 'Animal'
    public abstract class Animal
    {
        protected string Weight { get; set; }
        protected string Height { get; set; }

        public Animal(string weight, string height)
        {
            this.Weight = weight;
            this.Height = height;
        }

        // Phương thức trừu tượng để in thông tin (sẽ được cài đặt bởi các lớp dẫn xuất)
        public abstract void PrintInfo();
    }

    // Lớp dẫn xuất 'Cat' kế thừa từ 'Animal'
    class Cat : Animal
    {
        private string Name { get; set; }

        public Cat(string weight, string height, string name)
            : base(weight, height)
        {
            this.Name = name;
        }

        // Override phương thức để cung cấp triển khai cụ thể cho cách mèo in thông tin
        public override void PrintInfo()
        {
            Console.WriteLine("Trọng lượng : {0}" + '\n' + "Chiều cao: {1}" + '\n' + "Tên: {2}", this.Weight, this.Height, this.Name);
        }
    }

    // Chương trình chính
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5", "Kitty");

            // Gọi phương thức được override
            cat.PrintInfo();
        }
    }
}