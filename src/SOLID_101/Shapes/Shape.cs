namespace SOLID_101.Shapes;

// Base class for all shapes
public abstract class Shape : IShape
{
    // Abstract method to be overriden
    public abstract double CalculateArea();
}