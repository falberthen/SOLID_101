using System;

namespace SOLID_101.Shapes
{
    public class Square : Rectangle
    {        
        public double Sides { get; private set; }

        public Square(double sides): base(sides, sides)
        {
            Sides = sides;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Sides,2);
        }
    }
}
