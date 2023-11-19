using System;
using Shape;

namespace Shape
{
  class Program
  {
    static void Main(string[] args)
    {
      // Shape Test
      Shape shape = new Shape();
      Console.WriteLine(shape);

      shape = new Shape("red", false);
      Console.WriteLine(shape);

      // Circle Test
      Circle circle = new Circle();
      Console.WriteLine(circle);

      circle = new Circle(3.5);
      Console.WriteLine(circle);

      circle = new Circle(3.5, "indigo", false);
      Console.WriteLine(circle);

      // Square Test
      Square square = new Square();
      Console.WriteLine(square);

      square = new Square(2.3);
      Console.WriteLine(square);

      square = new Square(5.8, "yellow", true);
      Console.WriteLine(square);

            //Tạo một mảng các đối tượng hình học trong đó có ít nhất một Square. Với mỗi phần tử trong mảng, hiển thị diện tích của nó, nếu phần tử đó là một IColorable, gọi phương thức HowToColor().

            // Create an array of geometric objects
            Shape[] shapes = new Shape[]
            {
                new Circle(5.0, "Red", true),
                new Rectangle(4.0, 6.0, "Blue", false),
                new Square(3.0, "Green", true)
            };

            // Display the area of each shape and call HowToColor for IColorable shapes
            foreach (var result in shapes)
            {
                Console.WriteLine($"Area: {shapes.GetArea()}");

                // Check if the shape implements IColorable
                if (shape is IColorable colorableShape)
                {
                    colorableShape.HowToColor();
                }

                Console.WriteLine(); // Separate each shape's information
            }

        }
  }
}
