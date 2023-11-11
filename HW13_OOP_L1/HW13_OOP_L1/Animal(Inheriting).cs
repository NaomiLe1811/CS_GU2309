using System;
namespace HW13_OOP_L1
{
    //abstract is important in the process of inheristance and capsulation
    public abstract class Animal_Inheriting_
    {
        //Bước 1: Tạo class Animal, khai báo thuộc tính (properties) , định nghĩa hàm khởi tạo (contructor), và hàm PrintInfo là 1 abtract method hàm này sẽ được lớp con triển khai (implement)

        //tao properties (thuoc tinh)
        protected string Colour { get; set; }
        protected string Type { get; set; }

        // Constructor
        public Animal_Inheriting_(string colour, string type)
        {
            this.Colour = colour; //**
            this.Type = type;
        }

        // Phương thức trừu tượng để in thông tin (sẽ được cài đặt bởi các lớp dẫn xuất)
        public abstract void PrintInfo();
    }

    //Bước 2: Tạo class Cat kế thừa từ lớp Animal, khai báo properties, constructor, và override hàm PrintInfo
    // Lớp dẫn xuất 'Cat' kế thừa từ 'Animal'
    // Derived class
    class Cat : Animal_Inheriting_
    {
        public string Name { get; set; } //*

        public Cat(string colour, string type, string name) : base(colour, type) //**
        {
            this.Name = name; //*
        }

        //để hiển thị thông tin của con mèo.
        public override void PrintInfo()
        {
            Console.WriteLine("Colour : {0}" + '\n' + "Type: {1}" + '\n' + "Name: {2}", this.Colour, this.Type, this.Name);
        }

    }
}
