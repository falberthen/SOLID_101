namespace SOLID_101.Shapes;

public class Circle : Shape, ICircle
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2),2);
    }
}