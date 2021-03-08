namespace SOLID_101.Shapes;

public class EquilateralTriangle : Shape, ITriangle
{
    public double Sides { get; set; }

    public EquilateralTriangle(double sides)
    {
        Sides = sides;
    }

    public override double CalculateArea()
    {
        return Math.Round((Math.Sqrt(3) / 4) * (Sides * Sides), 2);
    }
}