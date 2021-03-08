using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_101.Shapes
{
    /// <summary>
    /// Shape definition
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Abstract method opens the class to extension
        /// Can be implemented through polymorphism to all shapes
        /// </summary>
        /// <returns></returns>
        abstract double CalculateArea();
    }
}
