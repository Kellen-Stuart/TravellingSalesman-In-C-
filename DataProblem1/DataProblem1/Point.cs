using System;
using System.Reflection.Metadata.Ecma335;

namespace DataProblem1
{
    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
        
    }

    public static class PointExtensions
    {
        public static double CalculateDistance(this Point pointA, Point pointB)
        {
            if (pointA.IsTriangle(pointB))
                return pointA.PythagoreanTheorem(pointB);

            if (Math.Abs(pointA.X - pointB.X) != 0)
                return Math.Abs(pointA.X - pointB.X);

            if (Math.Abs(pointA.Y - pointB.Y) != 0)
                return Math.Abs(pointA.Y - pointB.Y);

            return 0;
        }

        public static bool IsTriangle(this Point pointA, Point pointB)
        {
            return pointA.X != pointB.X && pointA.Y != pointB.Y;
        }

        private static double PythagoreanTheorem(this Point pointA, Point pointB)
        {
            var distX = Math.Abs(pointA.X - pointB.X);
            var distY = Math.Abs(pointA.Y - pointB.Y);
            return Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2));
        }
    }
}