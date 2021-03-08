namespace SOLID_101.Services.Interfaces;

public interface IShapeRendererFactory
{
    IShapeRenderer<IShape> GetRendererFromShape(IShape shape);
}