using SOLID_101.Shapes;

namespace SOLID_101.Services
{
    public class RectangularRenderService : RenderService<Rectangle>
    {
        public RectangularRenderService(IWritingService writingService)
        {
            _writingService = writingService;
        }

        public override void Render(Rectangle rectangle)
        {
            for (double i = 1; i <= rectangle.Height; i++)
            {
                for (double j = 1; j <= rectangle.Width; j++)
                {
                    if ((i == 1 || j == 1 || i == rectangle.Height || j == rectangle.Width))
                        _writingService.Write("- ");
                    else
                        _writingService.Write("  ");
                }

                _writingService.WriteLine();
            }
        }

        private IWritingService _writingService;
    }
}
