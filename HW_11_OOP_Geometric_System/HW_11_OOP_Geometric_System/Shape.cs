using System;
namespace HW_11_OOP_Geometric_System
{
    public class Shape
    {
        //create properties
        private string color { get; set; }
        private bool filled { get; set; }

        // Create constructor with default values, NO INPUT NEEDED
        public Shape()
        {
            this.color = "Green";
            this.filled = true;
        }
        // Create constructor with arguments, INPUT NEEDED
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        //create override string
        public override string ToString()
        {
            return $"A Shape with color of {color} and {filled}";
        }

        public class Circle : Shape
        {
            public double radius;        
            //constructor 1
            public Circle() { radius = 1.0; }
            //constructor 2
            public Circle(double radius)
            {
                this.radius = radius;
            }
            //constructor 3
            public Circle(string color, bool filled, double radius) : base(color, filled)
            {
                this.radius = radius;
            }

            public double GetArea(double width, double height)
            {
                return Math.PI * radius * radius;
            }
            public double GetPerimeter(double width, double height)
            {
                return 2 * Math.PI * radius;
            }
            public override string ToString()
            {
                return $"A Circle with radius {radius}, which is a subclass of {//radius} ";
            }
        }

        public class Retangle : Shape
        {
            public double width;{ get; set; }
            public double length;{ get; set; }

            public Retangle(double width = 1.0, double length = 1.0) { }
            public 

        }

    }
}
