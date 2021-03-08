namespace SOLID_101.Services.Interfaces;

public interface IShapeRenderer<out T> 
    where T : IShape
{
    char RenderCharacter { get; }
    void Render(IShape shape);
}