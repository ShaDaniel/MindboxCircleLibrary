using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
