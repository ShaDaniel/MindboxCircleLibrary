using System;

namespace MindboxFigureLibrary
{
    public class Circle
    {
        public static double GetArea(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be bigger than 0");
            }

            return Math.PI * radius * radius;
        }
    }
}