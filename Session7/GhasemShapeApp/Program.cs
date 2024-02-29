Console.WriteLine("Enter the shape type (1. rectangle, 2. square, 3. triangle):");
string shapeType = Console.ReadLine().ToLower();

Console.WriteLine("Enter the property (1. area, 2. perimeter):");
string property = Console.ReadLine().ToLower();

if (shapeType == "rectangle")
{
    if (property == "area")
    {

    }
    else if (property == "perimeter")
    {
        Console.WriteLine("Enter the length:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the width:");
        double width = Convert.ToDouble(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
    }
    else
    {
        Console.WriteLine("Invalid property!");
    }
}
else if (shapeType == "square")
{
    if (property == "area")
    {
        Console.WriteLine("Enter the side length:");
        double side = Convert.ToDouble(Console.ReadLine());
        double area = side * side;
        Console.WriteLine("Area of the square: " + area);
    }
    else if (property == "perimeter")
    {
        Console.WriteLine("Enter the side length:");
        double side = Convert.ToDouble(Console.ReadLine());
        double perimeter = 4 * side;
        Console.WriteLine("Perimeter of the square: " + perimeter);
    }
    else
    {
        Console.WriteLine("Invalid property!");
    }
}
else if (shapeType == "triangle")
{
    if (property == "area")
    {
        Console.WriteLine("Enter the base length:");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Convert.ToDouble(Console.ReadLine());
        double area = 0.5 * baseLength * height;
        Console.WriteLine("Area of the triangle: " + area);
    }
    else if (property == "perimeter")
    {
        Console.WriteLine("Enter the first side length:");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second side length:");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the third side length:");
        double side3 = Convert.ToDouble(Console.ReadLine());
        double perimeter = side1 + side2 + side3;
        Console.WriteLine("Perimeter of the triangle: " + perimeter);
    }
    else
    {
        Console.WriteLine("Invalid property!");
    }
}
else
{
    Console.WriteLine("Invalid shape type!");
}


static void RectangleArea()
{
    Console.WriteLine("Enter the length:");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter the width:");
    double width = Convert.ToDouble(Console.ReadLine());
    double area = length * width;
    Console.WriteLine("Area of the rectangle: " + area);
}