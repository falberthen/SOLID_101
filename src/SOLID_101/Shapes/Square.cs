namespace SOLID_101.Shapes;

public class Square : Shape, ISquare
{
    public double SideLength { get; private set; }

    public Square(double sideLength)
    {
        SideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return SideLength * SideLength;
    }
}