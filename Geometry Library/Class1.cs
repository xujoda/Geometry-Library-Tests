
namespace Geometry_Library
{
    interface IShape
    {
        double GetArea();
    }

    public class Shape : IShape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _sideD;
        private double _h;

        public Shape(double sideA = 0, double sideB = 0, double sideC = 0, double sideD = 0, double h = 0)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _sideD = sideD;
            _h = h;            
        }

        public double GetArea()
        {// в этих условных операторах я подразумеваю, что пользователь будет по порядку записывать значения :D
            if (_sideA == _sideC && _sideB == _sideD && _h == 0) 
                return isRectangular();
            if ((_sideB == 0 && _h != 0) || (_sideA == _sideB && _sideB == _sideC && _sideC == _sideD && _h != 0))
                return isRightParallelogram();
            if (_sideA != _sideB && _h != 0)
                return isTrapezoid();
            return 0;
        }

        private double isRectangular()
        {
            return _sideA * _sideB;
        }

        private double isRightParallelogram()
        {
            return _sideA * _h;
        }

        private double isTrapezoid()
        {
            return 0.5 * (_sideA + _sideC) * _h;
        }
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

        public new double GetArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return (Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC)));
        }

        public bool IsRightTriangle()
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

        public new double GetArea()
        {
            return (Math.PI * _radius * _radius);
        }
    }
}
