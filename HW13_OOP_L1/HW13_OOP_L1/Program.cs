using System;

namespace HW13_OOP_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1_HCN();
            Exercise2_Animal();
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
    }
}
