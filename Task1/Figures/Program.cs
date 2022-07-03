using System;
using System.Collections.Generic;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> figures = new List<IFigure>();
            figures.Add(new Triangle(1, 2, 2.4f));
            Circle circle = new Circle(4);
            figures.Add(circle);
            Triangle triangle = new Triangle(3, 4, 5);
            figures.Add(triangle);

            TestFigures.TestIsRectangularTriangle(triangle, true);
            TestFigures.TestArea(triangle, 6);
            TestFigures.TestArea(circle, 16*MathF.PI);
            try
            {
                figures.Add(new Triangle(1, 2, 4));
            }
            catch (Exception e)
            {
                Console.WriteLine("figure not Add: " + e.Message);
            }
            Console.WriteLine();

            for (int i = 0; i < figures.Count; i++)
            {
                var figure = figures[i];
                Console.WriteLine($"figure {i+1} Area = {figure.CalculateArea()}");
            }
        }
    }


}
