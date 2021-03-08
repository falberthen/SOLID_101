using SOLID_101.Shapes;

namespace SOLID_101.Services
{
    /// <summary>
    /// Render service implementation for Shape
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class RenderService<T> : IRenderService<T> where T : Shape
    {
        public abstract void Render(T shape);
    }
}
