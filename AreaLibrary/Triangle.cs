using System;

namespace AreaLibrary
{
    public class Triangle : Shape
    {
        private double _sideAB { get; set; }
        private double _sideBC { get; set; }
        private double _sideAC { get; set; }

        public Triangle(double sideAB, double sideBC, double sideAC)
        {
            if (IsTriangle(sideAB, sideBC, sideAC))
            {
                _sideAB = sideAB;
                _sideBC = sideBC;
                _sideAC = sideAC;
            }
        }

        public override double Сalculation()
        {
            double p = (_sideAB + _sideBC + _sideAC) / 2;
            return Math.Round(Math.Sqrt(p * (p - _sideAB) * (p - _sideBC) * (p - _sideAC)), 2);
        }

        public bool IsRectangularTriangle()
        {
            bool isRectangular = (_sideAB == Math.Sqrt(Math.Pow(_sideBC, 2) + Math.Pow(_sideAC, 2)))
                            || (_sideBC == Math.Sqrt(Math.Pow(_sideAB, 2) + Math.Pow(_sideAC, 2)))
                            || (_sideAC == Math.Sqrt(Math.Pow(_sideAB, 2) + Math.Pow(_sideBC, 2)));

            bool result = isRectangular ? true : false;
            return result;
        }

        private bool IsTriangle(double sideAB, double sideBC, double sideAC)
        {
            if (sideAB <= 0 || sideBC <= 0 || sideAC <= 0)
                throw new Exception("Стороны треугольника должны быть положительными числами");

            if (sideAB >= sideBC + sideAC || sideBC >= sideAB + sideAC || sideAC >= sideAB + sideBC)
                throw new Exception("Треугольника с такими сторонами не существует");

            return true;
        }
    }
}
