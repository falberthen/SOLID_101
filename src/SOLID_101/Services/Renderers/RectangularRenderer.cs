namespace SOLID_101.Services.Renderers;

public sealed class RectangularRenderer<T> : IShapeRenderer<T> 
    where T : IRectangle
{
    public char RenderCharacter => '-';

    public void Render(IShape shape)
    {
        if (!(shape is IRectangle rectangle))
            throw new InvalidShapeTypeException("Shape must be retangular.");

        Console.ForegroundColor = ConsoleColor.Blue;

        for (int i = 1; i <= rectangle.Height; i++)
        {
            for (int j = 1; j <= rectangle.Width; j++)
            {
                bool isBorder = i == 1 || j == 1 || i == rectangle.Height || j == rectangle.Width;
                Console.Write(isBorder ? $"{RenderCharacter} " : "  ");
            }

            Console.WriteLine();
        }
    }
}