using System;
using System.Collections.Generic;
namespace HW_13_OOP_Point2D_Point3D
{
    public class Point3D : Point2D //nho dong nay
    {
        private double z;

        public Point3D(double x = 0, double y = 0, double z = 0): base(x,y) //nho dong nay
        {
            this.z = z;
        }

        public double Z { get => z; set => z = value; }

        public void SetXYZ(double x, double y, double z = 0.0)
        {
            base.SetXY(x, y);
            this.z = z;
        }
        public List<double> GetXYZ()
        {
            List<double> result = new List<double>();
            result = base.GetXY();
            result.Add(z);

            return result;
        }

        public override string ToString()
        {
            return string.Format("(x = {0},y = {1},z = {2})", X, Y, this.z);
        }
    }
}
