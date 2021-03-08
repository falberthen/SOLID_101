namespace SOLID_101.Services.Renderers;

public sealed class TriangularRenderer : IShapeRenderer<EquilateralTriangle>
{
    public char RenderCharacter => '.';

    public void Render(IShape shape)
    {
        if (!(shape is EquilateralTriangle triangle))
            throw new InvalidShapeTypeException("Shape must be an EquilateralTriangle.");

        Console.ForegroundColor = ConsoleColor.Green;

        for (double i = 0; i < triangle.Sides; i++)
        {
            for (double j = triangle.Sides - i; j > 0; j--)
                Console.Write(" ");

            for (double j = 0; j <= i; j++)
                Console.Write($"{RenderCharacter} ");

            Console.WriteLine();
        }
    }
}