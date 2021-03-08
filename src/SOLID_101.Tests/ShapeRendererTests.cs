namespace SOLID_101.Tests;

public class ShapeRendererTests
{
    [Fact]
    public void Render_CircleWithCircularRenderer_RenderCircle()
    {
        // Arrange
        var renderer = new CircularRenderer();
        var circle = new Circle(5);

        // Act & Assert
        renderer.Render(circle);
    }

    [Fact]
    public void Render_RectangleWithRectangularRenderer_RenderRectangle()
    {
        // Arrange
        var renderer = new RectangularRenderer<Rectangle>();
        var rectangle = new Rectangle(10, 15);

        // Act & Assert
        renderer.Render(rectangle);
    }

    [Fact]
    public void Render_SquareWithSquareRenderer_RenderSquare()
    {
        // Arrange
        var renderer = new SquareRenderer<Square>();
        var square = new Square(10);

        // Act & Assert
        renderer.Render(square);
    }

    [Fact]
    public void Render_EquilateralTriangleWithTriangularRenderer_RenderEquilateralTriangle()
    {
        // Arrange
        var renderer = new TriangularRenderer();
        var triangle = new EquilateralTriangle(10);

        // Act & Assert
        renderer.Render(triangle);
    }

    [Fact]
    public void Render_SquareWithCircularRenderer_ThrowsException()
    {
        // Arrange
        var renderer = new CircularRenderer();
        var square = new Square(5); // Providing a Square instead of a Circle

        // Act & Assert
        Assert.Throws<InvalidShapeTypeException>(() => 
            renderer.Render(square));
    }

    [Fact]
    public void Render_EquilateralTriangleWithRectangularRenderer_ThrowsException()
    {
        // Arrange
        var renderer = new RectangularRenderer<Rectangle>();
        var triangle = new EquilateralTriangle(10); // Providing a Triangle instead of a Rectangle

        // Act & Assert
        Assert.Throws<InvalidShapeTypeException>(() => 
            renderer.Render(triangle));
    }

    [Fact]
    public void Render_RectangleWithTriangularRenderer_ThrowsException()
    {
        // Arrange
        var renderer = new TriangularRenderer();
        var rectangle = new Rectangle(10, 15); // Providing a Rectangle instead of a Triangle

        // Act & Assert
        Assert.Throws<InvalidShapeTypeException>(() => 
            renderer.Render(rectangle));
    }
}