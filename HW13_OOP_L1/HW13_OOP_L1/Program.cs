using System;

namespace HW13_OOP_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1_HCN();
            //Exercise2_Animal();
            Exercise3_Student();
        }

        static void Exercise1_HCN()
        {
            // Provide actual values for Dai and Rong
            double Dai = 5.0;
            double Rong = 3.0;

            //tao instance moi cho hinhchunhat
            HinhChuNhat hcn = new HinhChuNhat(Dai, Rong);

            //in chu vi
            double chuVi = hcn.ChuVi();
            Console.WriteLine("Chu vi la: " + chuVi);

            //in dien tich
            double dienTich = hcn.DienTich();
            Console.WriteLine("Dien tich la: " + dienTich);

            //in ra man hinh
            string displayResult = hcn.Display();
            Console.WriteLine("In ra: " + displayResult);
        }
        static void Exercise2_Animal()
        {
            Cat cat = new Cat("White", "British", "Muop");
            cat.PrintInfo();
        }
        static void Exercise3_Student()
        {
            Student.Change();//calling change method
                             //creating objects
            Student s1 = new Student(22, "Elias");
            Student s2 = new Student(43, "Joihn");
            Student s3 = new Student(55, "Anna");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();

        }
    }
}
