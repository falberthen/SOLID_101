namespace SOLID_101.Services.Renderers;

public sealed class CircularRenderer : IShapeRenderer<Circle>
{
    public char RenderCharacter => '.';
    private const double _thickness = 0.1;

    public void Render(IShape shape)
    {
        if (!(shape is Circle circle))
            throw new InvalidShapeTypeException("Shape must be a Circle.");

        double radius = circle.Radius;
        double rIn = radius - _thickness;
        double rOut = radius + _thickness;

        var output = new StringBuilder();

        for (double y = radius; y >= -radius; --y)
        {
            for (double x = -radius; x < rOut; x += 0.5)
            {
                double value = x * x + y * y;
                output.Append(value >= rIn * rIn && value <= rOut * rOut ? RenderCharacter : " ");
            }

            output.AppendLine();
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(output);
    }
}

// https://www.csharp-console-examples.com/general/draw-a-circle-in-c-console-application/