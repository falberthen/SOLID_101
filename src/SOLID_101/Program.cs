using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
        services.ConfigureShapeRenderers()
    )
    .Build();
IServiceProvider serviceProvider = host.Services;

// Shape Render Factory
IShapeRendererFactory shapeRenderFactory = serviceProvider
    .GetRequiredService<IShapeRendererFactory>();

// List of Shapes
List<Shape> shapes = new()
{
    new Rectangle(10, 15),
    new Square(10),
    new EquilateralTriangle(10),
    new Circle(5)
};

// Rendering all shapes
shapes.ForEach(shape =>
{
    // Gets the specific renderer based on the shape   
    var shapeRenderer = shapeRenderFactory.GetRendererFromShape(shape);

    // Render the shape using the renderer
    shapeRenderer.Render(shape);

    Console.WriteLine($"\n{shape.GetType().Name} area: {shape.CalculateArea()}\n\n");
});


Console.ReadLine();