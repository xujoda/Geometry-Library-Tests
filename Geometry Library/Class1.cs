
namespace Geometry_Library
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double GetArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return (Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC)));
        }

        public bool IsRightAngled()
        {
            double hypotenuse = Math.Max(_sideA, Math.Max(_sideB, _sideC));
            double sumOfLegSquares = 0;

            sumOfLegSquares = _sideA * _sideA + _sideB * _sideB + _sideC * _sideC - hypotenuse * hypotenuse;
            
            return (hypotenuse * hypotenuse == sumOfLegSquares);
        }
    }

    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return (Math.PI * _radius * _radius);
        }
    }
}
