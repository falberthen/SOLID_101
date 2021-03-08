namespace SOLID_101.Shapes;

public class Rectangle :  Shape, IRectangle
{
    public double Height { get; private set; }
    public double Width { get; private set; }

    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Height * Width;
    }
}