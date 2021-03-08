using SOLID_101.Shapes;

namespace SOLID_101.Services
{
    /// <summary>
    /// Render service definition
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRenderService<T> where T : Shape
    {
        public abstract void Render(T shape);
    }
}
