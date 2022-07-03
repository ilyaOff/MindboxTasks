using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class TestFigures
    {
        private static int numberTest = 0;
        public static void TestArea(IFigure figure, float correctArea)
        {
            numberTest++;
            float result = figure.CalculateArea();
            if (result == correctArea)
                Console.WriteLine($"{numberTest}) Test is correct");
            else
                Console.WriteLine($"{numberTest}) Test Area is incorrect:\n" +
                                $" Calculate area {result} != correct Area {correctArea}");
        }

        public static void TestIsRectangularTriangle(Triangle triangle, bool correctAnswer)
        {
            numberTest++;
            bool result = triangle.IsRectangular();
            if (result == correctAnswer)
                Console.WriteLine($"{numberTest}) Test is correct");
            else
                Console.WriteLine($"{numberTest}) Test Is Rectangular Triangle is incorrect:\n" +
                                $" Calculate IsRectangular {result}, but correct is {correctAnswer}");
        }
    }
}
