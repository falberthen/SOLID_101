namespace SOLID_101.Tests;

public class ShapeRendererFactoryTests
{
    [Fact]
    public void GetRendererFromShape_WithRegisteredShape_ReturnsCorrectRenderer()
    {
        // Arrange
        var serviceProvider = Substitute.For<IServiceProvider>();
        var circleRenderer = new CircularRenderer();
        serviceProvider.GetService(typeof(IShapeRenderer<Circle>))
            .Returns(circleRenderer);

        var factory = new ShapeRendererFactory(serviceProvider);
        var circle = new Circle(5);

        // Act
        var renderer = factory.GetRendererFromShape(circle);

        // Assert
        Assert.Equal(typeof(CircularRenderer), circleRenderer.GetType());
        Assert.Equal(circleRenderer, renderer);
    }

    [Fact]
    public void GetRendererFromShape_WithNonRegisteredShape_ThrowsException()
    {
        // Arrange
        var serviceProvider = Substitute.For<IServiceProvider>();
        var circleRenderer = new CircularRenderer();
        serviceProvider.GetService(typeof(IShapeRenderer<Circle>))
            .Returns(circleRenderer);

        var factory = new ShapeRendererFactory(serviceProvider);
        var unsupportedShape = new CustomShape();

        // Act & Assert
        Assert.Throws<NotSupportedException>(() =>
            factory.GetRendererFromShape(unsupportedShape));
    }
}

// Custom non-registered shape
public class CustomShape : IShape
{
    public double CalculateArea() => 0;
}
