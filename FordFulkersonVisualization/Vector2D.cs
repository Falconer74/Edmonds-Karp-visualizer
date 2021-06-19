using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordFulkersonVisualization
{
    public class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D()
        {

        }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vector2D(Point p1, Point p2)
        {
            X = p2.X - p1.X;
            Y = p2.Y - p1.Y;
        }

        public Vector2D GetReverseVector()
        {
            return new Vector2D(-X, -Y);
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public void Normalize()
        {
            double magnitude = GetMagnitude();

            X /= magnitude;
            Y /= magnitude;
        }

        public Vector2D GetPerpendicularClockwise()
        {
            return new Vector2D(Y, -X);
        }

        public Vector2D GetPerpendicularCounterClockwise()
        {
            return new Vector2D(-Y, X);
        }

        public Point MovePoint(Point p)
        {
            Point newPoint = new Point();
            newPoint.X = p.X + X;
            newPoint.Y = p.Y + Y;

            return newPoint;
        }

        public void Multiply(double k)
        {
            X *= k;
            Y *= k;
        }

        public double DotProduct(Vector2D v)
        {
            return X * v.X + Y * v.Y;
        }
        public double GetAngle(Vector2D v)
        {
            double n = DotProduct(v) / (GetMagnitude() * v.GetMagnitude());

            return (180 / Math.PI) * Math.Acos(n);
        }
    }
}
