using System;

namespace Example10
{
    internal class AreaCalculator
    {
        public double Area(Rectangle[] shapes)
        {
            double area = 0;

            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }

            return area;
        }

        public double Area(object[] shapes)
        {
            double area = 0;

            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    var rectangle = (Rectangle)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else
                {
                    var circle = (Circle)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
