namespace SOLID_101.Services.Renderers;

public sealed class SquareRenderer<T> : IShapeRenderer<T>
    where T : ISquare
{
    public char RenderCharacter => '-';

    public void Render(IShape shape)
    {
        if (!(shape is ISquare square))
            throw new InvalidShapeTypeException("Shape must be a square.");

        Console.ForegroundColor = ConsoleColor.Blue;

        for (int i = 1; i <= square.SideLength; i++)
        {
            for (int j = 1; j <= square.SideLength; j++)
            {
                bool isBorder = i == 1 || j == 1 || i == square.SideLength || j == square.SideLength;
                Console.Write(isBorder ? $"{RenderCharacter} " : "  ");
            }

            Console.WriteLine();
        }
    }
}
