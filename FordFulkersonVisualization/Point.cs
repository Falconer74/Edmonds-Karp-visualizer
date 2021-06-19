using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordFulkersonVisualization
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void MovePoint(Vector2D v)
        {
            X += v.X;
            Y += v.Y;
        }

        static public Point GetMidPoint(Point p1, Point p2)
        {
            return new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }
    }
}
