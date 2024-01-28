using NUnit.Framework;
using Test_lib;
using System;
using NUnit.Framework.Legacy;
namespace Test_lib.Tests
{
    [TestFixture]
    public class FigureTests
    {
        [Test]
        public void Circle_AreaCalculation_Correct()
        {
            double radius = 5;
            double Expected_area = Math.PI * radius * radius;
            Circle circle = new Circle(radius);
            double Actual_area = circle.Calculate_area();
            Assert.That(Expected_area, Is.EqualTo(Actual_area));
        }

        [Test]
        public void Circle_NegativeRadius_ThrowsArgumentException()
        {
            double radius = -5;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Test]
        public void Triangle_AreaCalculation_Correct()
        {
            double side1 = 5;
            double side2 = 5;
            double side3 = 6;
            double Expected_area = 12;
            Triangle triangle = new Triangle(side1, side2, side3);

            double Actual_area = triangle.Calculate_area();

            Assert.That(Expected_area, Is.EqualTo(Actual_area));
        }

        [Test]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            double side1 = 1;
            double side2 = 1;
            double side3 = 10;

            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }
        [Test]
        public void Triangle_NegativeSide_ThrowsArgumentException()
        {
            double side1 = -3;
            double side2 = 4;
            double side3 = 5;

            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }
        [Test]
        public void Triangle_RightTriangle_AreaCalculation_Correct()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double Expected_area = 6;
            Triangle triangle = new Triangle(side1, side2, side3);

            double Actual_area = triangle.Calculate_area();

            Assert.That(Expected_area, Is.EqualTo(Actual_area));
        }       
    }
}
