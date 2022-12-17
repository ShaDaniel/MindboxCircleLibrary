using System;
using Xunit;

namespace MindboxFigureLibrary.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void GetAreaBySides_SomeSidesAreNegative_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => Triangle.GetAreaBySides(1, 2, -1));
        }

        [Fact]
        public void GetAreaBySides_SomeSidesAreZero_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => Triangle.GetAreaBySides(0, 0, 3));
        }

        [Fact]
        public void GetAreaBySides_SegmentsDoNotFormTriangle_ShouldThrow()
        {
            Assert.Throws<ArithmeticException>(() => Triangle.GetAreaBySides(1, 2, 3));
        }

        [Fact]
        public void GetAreaBySides_SomeCorrectSides_ShouldCalculateArea()
        {
            Assert.True(CommonCalculations.AreApproximatelyEqual(1.7320508, Triangle.GetAreaBySides(2, 2, 2)));
        }

        [Fact]
        public void IsRightTriangle_TrulyRight_ReturnTrue()
        {
            Assert.True(Triangle.IsRightTriangle(3, 4, 5));
        }

        [Fact]
        public void IsRightTriangle_IsNotATriangle_ShouldThrow()
        {
            Assert.Throws<ArithmeticException>(() => Triangle.IsRightTriangle(1, 2, 3));
        }
        
        [Fact]
        public void IsRightTriangle_IsNotRight_ReturnFalse()
        {
            Assert.False(Triangle.IsRightTriangle(5, 6, 7));
        }
    }
}
