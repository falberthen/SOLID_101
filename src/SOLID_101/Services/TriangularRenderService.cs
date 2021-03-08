using SOLID_101.Shapes;

namespace SOLID_101.Services
{
    public class TriangularRenderService : RenderService<EquilateralTriangle>
    {
        public TriangularRenderService(IWritingService writingService)
        {
            _writingService = writingService;
        }

        public override void Render(EquilateralTriangle triangle)
        {
            for (double i = 0; i < triangle.Sides; i++)
            {
                for (double j = triangle.Sides - i; j > 0; j--)
                    _writingService.Write(" ");

                for (double j = 0; j <= i; j++)
                    _writingService.Write(". ");

                _writingService.WriteLine();
            }
        }

        private IWritingService _writingService;
    }
}
