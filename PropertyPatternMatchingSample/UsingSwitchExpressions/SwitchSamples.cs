using System;

namespace UsingSwitchExpressions
{
    public class Circle
    {
        public int Radius { get; }
        public Circle(int radius) => Radius = radius;
    }

    public class Rectangle
    {
        public int Length { get; }
        public int Width { get; }
        public Rectangle(int length, int width) =>
            (Length, Width) = (length, width);
    }

    public class Triangle
    {
        public int Side1 { get; }
        public int Side2 { get; }
        public int Side3 { get; }

        public Triangle(int side1, int side2, int side3) =>
            (Side1, Side2, Side3) = (side1, side2, side3);

    }

    public static class SwitchExpressionSample
    {
        public static string DisplayShapeInfo(object shape)
        {
            //// -------------> Simple Example
            //return shape switch
            //{
            //    Rectangle r => $"Rectangle (l={r.Length} w={r.Width})",
            //    Circle c => $"Circle (r={c.Radius})",
            //    Triangle t => $"Triangle ({t.Side1}, {t.Side2}, {t.Side3})",
            //    _ => "Unkown Shape"
            //};

            //// -------------> More Complex Example
            return shape switch
            {
                Rectangle r => r switch
                {
                    _ when r.Length == r.Width => $"Square (s={r.Length})",
                    _ => $"Rectangle (l={r.Length} w={r.Width})"
                },
                Circle { Radius: 1 } c => $"Small Circle (r=1)",
                Circle c => $"Circle (r={c.Radius})",
                Triangle t => $"Triangle ({t.Side1}, {t.Side2}, {t.Side3})",
                _ => "Unkown Shape"
            };
        }
    }
}
