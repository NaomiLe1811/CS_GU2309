using System;
using System.Collections.Generic;

namespace HW_13_OOP_Point2D_Point3D
{
    public class Point2D
    {
        private double x;
        private double y;

        public Point2D(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public void SetXY(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public List<double> GetXY()
        {
            List<double> result = new List<double>();
            result.Add(this.x);
            result.Add(this.y);

            return result;
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1} ", x, y);
        }
    }
}
