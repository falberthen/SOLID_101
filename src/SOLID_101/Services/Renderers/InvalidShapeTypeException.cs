namespace SOLID_101.Services.Renderers;

public class InvalidShapeTypeException : Exception
{
    public InvalidShapeTypeException() { }

    public InvalidShapeTypeException(string message) 
        : base(message) { }

    public InvalidShapeTypeException(string message, Exception innerException) 
        : base(message, innerException) { }
}
