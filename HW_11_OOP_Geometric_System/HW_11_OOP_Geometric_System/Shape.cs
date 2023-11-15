using System;
namespace HW_11_OOP_Geometric_System
{
    public class Shape
    {
        //create properties
        private string color;
        private bool filled;

        // Create constructor with default values, NO INPUT NEEDED
        public Shape()
        {
            this.Color = "Green";
            this.Filled = true;
        }
        // Create constructor with arguments, INPUT NEEDED
        public Shape(string color, bool filled)
        {
            this.Color = color;
            this.Filled = filled;
        }

        public String GetColor()

        {
            return color;
        }

        public void SetColor(String color)

        {
            this.color = color;
        }

        public bool IsFilled()

        {
            return filled;
        }

        public void SetFilled(bool filled)

        {
            this.filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        //create override string
        public override string ToString()
        {
            return $"A Shape with color of {Color} and {Filled}";
        }

        public class Circle : Shape
        {
            private double radius;

            public double Radius { get => radius; set => radius = value; }

            //constructor 1
            public Circle() { Radius = 1.0; }
            //constructor 2
            public Circle(double radius)
            {
                this.Radius = radius;
            }
            //constructor 3
            public Circle(string color, bool filled, double radius) : base(color, filled)
            {
                this.Radius = radius;
            }

            public double GetArea(double width, double height)
            {
                return Math.PI * Radius * Radius;
            }
            public double GetPerimeter(double width, double height)
            {
                return 2 * Math.PI * Radius;
            }
            public override string ToString()
            {
                return $"A Circle with radius {Radius}, which is a subclass of {base.ToString()} ";
            }
        }

        public class Rectangle : Shape
        {
            private double width;
            private double length;

            public double Width { get => width; set => width = value; }
            public double Length { get => length; set => length = value; }

            public Rectangle(double width, double length, String color, bool filled) : base(color, filled)

            {
                this.width = width;
                this.length = length;
            }

            public double GetWidth()
            {
                return width;
            }

            public virtual void SetWidth(double width)
            {
                this.width = width;
            }
            public double GetLength()
            {
                return length;
            }

            public virtual void SetLength(double length)
            {
                this.length = length;
            }

            public double GetArea()
            {
                return (Width + Length) * 2;
            }
            public double GetPerimeter()
            {
                return Width * Length;
            }
            public override string ToString()
            {
                // Create an instance of Circle and call its ToString method
                Circle circle = new Circle();
                return $"A Rectangle with width {Width} and length {Length}, which is a subclass of {circle.ToString()} ";
            }
        }

        public class Square : Rectangle
        {
            private double side;

            public Square(double side) : base(side, side)
            {
                this.side = side;
            }

            public double Side { get => side; set => side = value; }


            public Square(double side, string color, bool filled) : base(side, side, color, filled)
            {
            }

            public override void SetWidth(double width)
            {
                SetSide(width);
            }

            public override void SetLength(double length)
            {
                SetSide(length);
            }

            private void SetSide(double side)
            {
                this.side = side;
            }
        }
    }
}
