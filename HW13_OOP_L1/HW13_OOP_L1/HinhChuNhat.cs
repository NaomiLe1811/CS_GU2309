using System;
namespace HW13_OOP_L1
{
    public class HinhChuNhat
    {
        //properties (data members)
        public double Dai { get; set; }
        public double Rong { get; set; }

        //Constructor
        public HinhChuNhat(double dai, double rong)
        {
            Dai = dai;
            Rong = rong;
        }

        //Method to get the perimeter.
        public double ChuVi()
        {
            return (Dai + Rong)*2;
        }


        //Method to get the retangle area.
        public double DienTich()
        {
            return Dai * Rong;
        }

        //in ra man hinh
        public string Display()
        {
        return "Rectangle{" + "Rong=" + Rong + ", Dai=" + Dai + "}";
        }

    }
}
