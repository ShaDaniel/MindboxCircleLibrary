using System;

namespace MindboxFigureLibrary
{
    public class CommonCalculations
    {
        public static bool AreApproximatelyEqual(double first, double second)
        {
            return Math.Abs(first - second) < Constants.E7;
        }
    }
}
