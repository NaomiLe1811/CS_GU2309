public class Rectangle
{
    double width, height;

    // Constructors
    public Rectangle()
    {
    }

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    // Methods
    public double GetArea()
    {
        return this.width * this.height;
    }

    public double GetPerimeter()
    {
        return (this.width + this.height) * 2;
    }

    public String Display()
    {
        return "Rectangle{" + "width=" + width + ", height=" + height + "}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // ...

        // Create an instance of the 'Rectangle' class
        Rectangle rectangle = new Rectangle(width, height);

        // Call methods on the 'rectangle' object
        Console.WriteLine("Your Rectangle \n" + rectangle.Display());
        Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
        Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
    }
}