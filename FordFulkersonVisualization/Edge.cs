using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FordFulkersonVisualization
{
    public class Edge : INotifyPropertyChanged
    {
        protected const double textOffset = 16;

        public event PropertyChangedEventHandler PropertyChanged;
        public Edge ResidualEdge;
        protected EdgeStatus status { get; set; }
        public EdgeStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;

                OnPropertyChanged("Status");
            }
        }
        protected int flow;
        public int Flow
        {
            get
            {
                return flow;
            }
            set
            {
                flow = value;

                if(capacity - flow <= 0 && Status != EdgeStatus.Saturated)
                {
                    Status = EdgeStatus.Saturated;
                }
                else if(Status == EdgeStatus.Saturated && capacity - flow > 0)
                {
                    Status = EdgeStatus.Default;
                }

                OnPropertyChanged("Flow");
            }
        }

        public void IncreaseFlow(int flow)
        {
            Flow += flow;
            ResidualEdge.Flow -= flow;
        }

        protected int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;

                OnPropertyChanged("Capacity");
            }
        }
        protected Vertex firstVertex;
        public Vertex FirstVertex
        {
            get
            {
                return firstVertex;
            }
            set
            {
                firstVertex = value;

                OnPropertyChanged("FirstVertex");
            }
        }
        protected Vertex secondVertex;
        public Vertex SecondVertex
        {
            get
            {
                return secondVertex;
            }
            set
            {
                secondVertex = value;

                OnPropertyChanged("SecondVErtex");
            }
        }

        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public Vector2D GetVector()
        {
            Point v1 = new Point()
            {
                X = FirstVertex.origin.X,
                Y = FirstVertex.origin.Y
            };

            Point v2 = new Point()
            {
                X = SecondVertex.origin.X,
                Y = SecondVertex.origin.Y
            };

            return new Vector2D(v1, v2);
        }
        public virtual Point StartPoint
        {
            get
            {
                Point newPoint = new Point()
                {
                    X = FirstVertex.origin.X,
                    Y = FirstVertex.origin.Y
                };

                return newPoint;
            }
        }
        public virtual Point EndPoint
        {
            get
            {
                Point newPoint = new Point()
                {
                    X = SecondVertex.origin.X,
                    Y = SecondVertex.origin.Y
                };

                Vector2D v = GetVector();
                v.Normalize();
                v = v.GetReverseVector();
                v.Multiply(SecondVertex.Radius / 2);
                newPoint = v.MovePoint(newPoint);

                return newPoint;
            }
        }

        public Point MidPoint
        {
            get
            {
                Vector2D v = GetVector();
                v = v.GetPerpendicularClockwise();
                v.Normalize();
                v.Multiply(textOffset);

                return v.MovePoint(Point.GetMidPoint(StartPoint, EndPoint));
            }
        }

        public double Angle
        {
            get
            {
                Vector2D v = GetVector();
                Vector2D unitVector = new Vector2D(-1, 0);
                double res = v.GetAngle(unitVector);

                if (res > 90)
                {
                    res -= 180;
                }

                return res;
            }
        }
    }

    public class PrimaryEdge : Edge
    {
        protected const double offset = 6;
        public override Point StartPoint
        {
            get
            {
                Point newPoint = new Point()
                {
                    X = FirstVertex.origin.X,
                    Y = FirstVertex.origin.Y
                };

                Vector2D v = GetVector();
                v = v.GetPerpendicularClockwise();
                v.Normalize();
                v.Multiply(offset);
                newPoint.MovePoint(v);

                return newPoint;
            }
        }
        public override Point EndPoint
        {
            get
            {
                Point newPoint = new Point()
                {
                    X = SecondVertex.origin.X,
                    Y = SecondVertex.origin.Y
                };

                Vector2D v = new Vector2D(StartPoint, newPoint);
                v.Normalize();
                v = v.GetReverseVector();
                v.Multiply(SecondVertex.Radius / 2);
                newPoint = v.MovePoint(newPoint);

                Vector2D v2 = GetVector();
                v2 = v2.GetPerpendicularClockwise();
                v2.Normalize();
                v2.Multiply(offset);
                newPoint.MovePoint(v2);

                return newPoint;
            }
        }
    }

    public class ResidualEdges : Edge
    {
        protected const double offset = 6;
        public override Point StartPoint
        {
            get
            {
                Point newPoint = new Point()
                {
                    X = FirstVertex.origin.X,
                    Y = FirstVertex.origin.Y
                };

                Vector2D v = GetVector();
                v = v.GetPerpendicularCounterClockwise();
                v.Normalize();
                v.Multiply(offset);
                newPoint.MovePoint(v);

                return newPoint;
            }
        }
        public override Point EndPoint
        {
            get
            {
                Point newPoint = new Point()
                {
                    X = SecondVertex.origin.X,
                    Y = SecondVertex.origin.Y
                };

                Vector2D v = new Vector2D(StartPoint, newPoint);
                v.Normalize();
                v = v.GetReverseVector();
                v.Multiply(SecondVertex.Radius / 2);
                newPoint = v.MovePoint(newPoint);

                Vector2D v2 = GetVector();
                v2 = v2.GetPerpendicularCounterClockwise();
                v2.Normalize();
                v2.Multiply(offset);
                newPoint.MovePoint(v2);

                return newPoint;
            }
        }
    }
}
