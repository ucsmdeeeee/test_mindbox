using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
namespace Test_lib
{
    public interface IFigure
    {
        double Calculate_area();
    }
    public class Circle : IFigure
    {
        private double radius;
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным");
            }
            this.radius = radius;
        }
        public double Calculate_area()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Triangle : IFigure
    {
        private double side1, side2, side3;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentException("Длина стороны треугольника не может быть отрицательной");
            }
            if (!Is_triangle_valid(side1, side2, side3))
            {
                throw new ArgumentException("Задан невозможный треугольник");
            }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public double Calculate_area()
        {
            if (Is_triangle_right(side1, side2, side3))
            {
                double hypotenuse = Math.Max(Math.Max(side1, side2), side3);
                if (hypotenuse == side1)
                {
                    return side2 * side3 / 2;
                }
                else if (hypotenuse == side2)
                {
                    return side1 * side3 / 2;
                }
                else
                {
                    return side1 * side2 / 2;
                }
            }
            double semi_perimeter = (side1 + side2 + side3) / 2;
            return Math.Sqrt(semi_perimeter * (semi_perimeter - side1) * (semi_perimeter - side2) * (semi_perimeter - side3));
        }
        private static bool Is_triangle_valid(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
        }
        private static bool Is_triangle_right(double side1, double side2, double side3)
        {
            double hypotenuse = Math.Max(Math.Max(side1, side2), side3);
            if (hypotenuse == side1)
            {
                return side1 * side1 == side2 * side2 + side3 * side3;
            }
            else if (hypotenuse == side2)
            {
                return side2 * side2 == side1 * side1 + side3 * side3;
            }
            else
            {
                return side3 * side3 == side1 * side1 + side2 * side2;
            }
        }
        
    }
    public class Programm()
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Triangle triangle = new Triangle(3, 4, 5);
        }
    }
}

