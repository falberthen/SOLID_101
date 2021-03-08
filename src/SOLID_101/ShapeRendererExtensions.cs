namespace SOLID_101;

public static class ShapeRendererExtensions
{
    public static void ConfigureShapeRenderers(this IServiceCollection services)
    {
        // Register shape renderer factory
        services.AddTransient<IShapeRendererFactory, ShapeRendererFactory>();

        // Register shape renderers
        services.AddTransient<IShapeRenderer<Rectangle>, RectangularRenderer<Rectangle>>();
        services.AddTransient<IShapeRenderer<Square>, SquareRenderer<Square>>();
        services.AddTransient<IShapeRenderer<EquilateralTriangle>, TriangularRenderer>();
        services.AddTransient<IShapeRenderer<Circle>, CircularRenderer>();
    }
}