using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Triangle : IFigure
    {
        private float[] _sides = new float[] { 1, 1, 1 };
        public IEnumerable<float> Sides => _sides;

        public Triangle(float[] sides)
        {
            if (sides.Length != 3)
                throw new System.ArgumentException("Must be 3 side in triangle!!!");

            if (CorrectSides(sides[0], sides[1], sides[2]))
                sides.CopyTo(_sides, 0);
            else
                throw new System.ArgumentException("Impossible triangles!");
        }
        public Triangle(float side1, float side2, float side3)
        {
            if (!CorrectSides(side1, side2, side3))
            {
                throw new System.ArgumentException("Impossible triangles!");
            }

            _sides[0] = side1;
            _sides[1] = side2;
            _sides[2] = side3;
        }

        private bool CorrectSides(float side1, float side2, float side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new System.ArgumentException("All side must be > 0!");

            float max = Math.Max(side1, Math.Max(side2, side3));
            /* min = Math.Min(side1, Math.Min(side2, side3));
            float midle = side1 + side2 + side3 - max - min;
            return max < min + midle;
            */
            return max < side1 + side2 + side3 - max;
        }

        public float CalculateArea()
        {
            float c = _sides[0];
            float a = _sides[1];
            float b = _sides[2];
            float p = (a + b + c) / 2;
            return MathF.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRectangular()
        {
            int max = 0;
            if (_sides[max] < _sides[1])
                max = 1;
            if (_sides[max] < _sides[2])
                max = 2;
            float c = _sides[max];
            float a = _sides[(max + 1) % 3];
            float b = _sides[(max + 2) % 3];
            return c * c == a * a + b * b;
        }
    }
}
