using System;

namespace AreaLibrary
{
    public class Circle : Shape
    {
        private double _radius { get; set; }

        public Circle(double radius)
        {
            if (IsPositiveRadius(radius))
                _radius = radius;
        }

        public override double Сalculation()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }

        private bool IsPositiveRadius(double radius)
        {
            if (radius <= 0)
                throw new Exception("Радиус должен быть больше 0");

            return true;
        }
    }
}
