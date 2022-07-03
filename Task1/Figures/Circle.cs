using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Circle : IFigure
    {
        public float Radius { get; private set; } = 1;

        public Circle(float radius)
        {
            if (radius < 0)
                throw new System.ArgumentException("radius must be >= 0!!!");

            Radius = radius;
        }
        public float CalculateArea()
        {
            return Radius * Radius * MathF.PI;
        }
    }
}
