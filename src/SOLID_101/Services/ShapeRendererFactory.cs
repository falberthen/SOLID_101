namespace SOLID_101.Services;

public class ShapeRendererFactory : IShapeRendererFactory
{
    private readonly IServiceProvider _serviceProvider;

    public ShapeRendererFactory(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public IShapeRenderer<IShape> GetRendererFromShape(IShape shape)
    {
        Type shapeType = shape.GetType();
        Type rendererType = typeof(IShapeRenderer<>).MakeGenericType(shapeType);

        var service = _serviceProvider.GetService(rendererType) 
            ?? throw new NotSupportedException($"Type {shapeType.FullName} has no render support.");

        return service as IShapeRenderer<IShape>;
    }
}