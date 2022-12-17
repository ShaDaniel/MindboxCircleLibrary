using System;
using Xunit;

namespace MindboxFigureLibrary.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_NegativeRadius_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => Circle.GetArea(-3.5));
        }

        [Fact]
        public void Circle_ZeroRadius_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => Circle.GetArea(0));
        }

        [Fact]
        public void Circle_SomeRadius_ShouldCalculateArea()
        {
            Assert.True(CommonCalculations.AreApproximatelyEqual(78.539816339744, Circle.GetArea(5)));
        }
    }
}