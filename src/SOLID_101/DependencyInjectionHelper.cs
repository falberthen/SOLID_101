using Microsoft.Extensions.DependencyInjection;
using SOLID_101.Services;
using SOLID_101.Shapes;

namespace SOLID_101
{
    /// <summary>
    /// Helper for DI
    /// </summary>
    public static class DependencyInjectionHelper
    {
        private static ServiceProvider _provider = InjectServices();

        public static ServiceProvider InjectServices()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            return serviceCollection.BuildServiceProvider();
        }

        public static RenderService<T> GetRenderService<T>() where T : Shape
        {
            return _provider.GetService<RenderService<T>>();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<RenderService<Rectangle>, RectangularRenderService>();
            services.AddTransient<RenderService<EquilateralTriangle>, TriangularRenderService>();
            services.AddTransient<IWritingService, ConsoleWritingService>();
        }
    }
}
