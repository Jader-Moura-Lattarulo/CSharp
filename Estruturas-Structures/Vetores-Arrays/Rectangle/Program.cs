var rectangle1 = new Rectangle(5,10);
var calculator = new ShapesMeansurementsCaculator();

Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"Height is {rectangle1.Height}");
Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle1));
Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle1));

var rectangle2 = new Rectangle(2, 3);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Height is {rectangle2.Height}");
Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle2));
Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle2));

Console.ReadKey();

class Rectangle
{
    public int Width = 7;
    public int Height = 9;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
}

class ShapesMeansurementsCaculator
{     
    
        public int CalculateRectangleCircumference(Rectangle rectangle)
        {
            return 2 + rectangle.Width + 2 * rectangle.Height;
        }

        public int CalculateRectangleArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }

    
}