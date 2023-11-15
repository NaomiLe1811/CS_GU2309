using System;
namespace Draft
{
    public class Circle
    {
        private double radius;
        private string color;

        public Circle(double radius = 5, string color = "Yellow")
        {
            this.radius = radius;
            this.color = color;
        }

        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return string.Format("Radius = {0}, Color = {1}", radius, color);
        }
    }

    public class Cylinder : Circle
    {
        private double height;

        public Cylinder(double radius = 5, string color = "Yellow", double height = 0) : base(radius, color)
        {
            this.height = height;
        }

        public double Height { get => height; set => height = value; }

        public double TheTich()
        {
            return height * (Math.PI * Radius * Radius);
        }

        public override string ToString()
        {
            return string.Format("Radius = {0}, Color = {1}, Height = {2}", Radius, Color, height);
        }
    }
}
