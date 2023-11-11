using System;
namespace HW13_OOP_L1
{
    public class Student
    {
        //properties
        private int rollNo;
        private string name;
        private int year;
        private static string college = "ABCD";

        //constructor
        public Student(int number, string Name)
        {
            this.name = Name;
            this.rollNo = number;
        }

        //static method to change the value of static variable
        public static void Change()
        {
            college = "CODEGYM";
        }

        //method to display value
        public void Display()
        {
            Console.WriteLine($"Ten hoc sinh la {name} voi so bao danh {rollNo} o truong hoc {college}", name, rollNo, college);
        }

        public void BiDuoiHoc()
        {
            year = 2004;
            Console.WriteLine($"Nhung {name} da bi duoi hoc vao nam {year}");
        }

    }
}
