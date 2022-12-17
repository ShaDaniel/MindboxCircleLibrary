using System;
using System.Collections.Generic;

namespace MindboxFigureLibrary
{
    public class Triangle
    {
        public static double GetAreaBySides(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Each side must be bigger than 0");
            }

            if (!DoesTriangleExist(a, b, c))
            {
                throw new ArithmeticException("A triangle with provided sides cannot exist");
            }

            var p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (!DoesTriangleExist(a, b, c))
            {
                throw new ArithmeticException("A triangle with provided sides cannot exist");
            }

            var sides = new List<double>{ a, b, c };
            sides.Sort();

            return CommonCalculations.AreApproximatelyEqual
                (sides[0] * sides[0] + sides[1] * sides[1], sides[2] * sides[2]);
        }

        private static bool DoesTriangleExist(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
