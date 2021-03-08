using System;
using System.Collections.Generic;
using SOLID_101.Shapes;

namespace SOLID_101
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(5, 10));
            shapes.Add(new Square(5));
            shapes.Add(new EquilateralTriangle(5));
            shapes.Add(new Circle(10));

            shapes.ForEach(shape => RenderWithArea(shape));
            Console.ReadLine();
        }

        private static void RenderWithArea(Shape shape)
        {
            if (shape is IRenderableShape)
                (shape as IRenderableShape).Render();

            Console.WriteLine("\n{0} area: {1}\n\n", 
                shape.GetType().Name, 
                shape.CalculateArea());
        }
    }
}