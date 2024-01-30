var rectangle1 = new Rectangle(5,10);
var calculator = new ShapesMeansurementsCaculator();

Console.WriteLine($"Width is {rectangle1.Width}");
Console.WriteLine($"Height is {rectangle1.GetHeight()}");
Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle1));
Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle1));

var rectangle2 = new Rectangle(2, 3);

Console.WriteLine($"Width is {rectangle2.Width}");
Console.WriteLine($"Height is {rectangle2.GetHeight()}");
Console.WriteLine("Area is " + calculator.CalculateRectangleArea(rectangle2));
Console.WriteLine("Circumference is " + calculator.CalculateRectangleCircumference(rectangle2));

Console.ReadKey();

class Rectangle
{
    const int NumberOfSides = 4;
    readonly int NumberOfSidesReadonly;
    public int Width { get; private set; }
    private readonly int _height;

    public Rectangle(int width, int height)
    {
        NumberOfSidesReadonly = 4;
        Width = GetLengthOrDefault(width, nameof(Width));
        _height = GetLengthOrDefault(height, nameof(_height));
    }

    public int GetHeight() => _height;

    public int Get_height()
    {
        return _height;
    }

    public void SetHeight(int value, int _height)
    {
        if(value > 0)
        {
            _height = value;
        }
    }

    private int GetLengthOrDefault(int length, string name)
    {
        int defaultValueNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return defaultValueNonPositive;
        }
        return length;
    }
}

class ShapesMeansurementsCaculator
{     
    
        public int CalculateRectangleCircumference(Rectangle rectangle)
        {
            return 2 + rectangle.Width + 2 * rectangle.GetHeight();
        }

        public int CalculateRectangleArea(Rectangle rectangle)
        {
            return rectangle.Width * rectangle.GetHeight();
        }

    
}