using System;

namespace SOLID_101.Shapes
{
    public class EquilateralTriangle : Shape, IRenderableShape
    {
        public double Sides { get; private set; }

        public EquilateralTriangle(double sides)
        {
            Sides = sides;
        }

        public override double CalculateArea()
        {
            return Math.Round((Math.Sqrt(3) / 4) * (Sides * Sides), 2);
        }

        public void Render()
        {
            var service = DependencyInjectionHelper.GetRenderService<EquilateralTriangle>();
            service.Render(this);
        }
    }
}
