// See https://aka.ms/new-console-template for more information
// Shape.cs
public abstract class Shape
{
    public abstract double GetArea();
}

// Circle.cs
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

// Rectangle.cs
public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the shape you want to calculate the area for (circle or rectangle):");
        string shapeType = Console.ReadLine();

        Shape shape;
        if (shapeType.ToLower() == "circle")
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            shape = new Circle(radius);
        }
        else if (shapeType.ToLower() == "rectangle")
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double width = double.Parse(Console.ReadLine());
            shape = new Rectangle(length, width);
        }
        else
        {
            Console.WriteLine("Invalid shape type. Please try again.");
            return;
        }

        Console.WriteLine($"The area of the {shapeType} is: {shape.GetArea()}");
    }
}
