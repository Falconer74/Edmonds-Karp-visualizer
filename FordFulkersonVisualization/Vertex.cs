using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordFulkersonVisualization
{
    public class Vertex : INotifyPropertyChanged
    {
        protected const int radius = 30;
        public int Radius
        {
            get
            {
                return radius;
            }
        }
        protected VertexStatus status;
        public VertexStatus Status
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
        public Point origin;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public int XPos
        {
            get
            {
                return (int)(origin.X - (Radius / 2));
            }
            set
            {
                origin.X = value;
            }
        }
        public int YPos
        {
            get
            {
                return (int)(origin.Y - (Radius / 2));
            }
            set
            {
                origin.Y = value;
            }
        }

        public List<Edge> IncomingEdges { get; set; }
        public List<Edge> OutcomingEdges { get; set; }

        public Vertex()
        {
            IncomingEdges = new List<Edge>();
            OutcomingEdges = new List<Edge>();
            origin = new Point();
        }
    }

    public class SourceVertex : Vertex
    {

    }

    public class SinkVertex : Vertex
    {

    }
}
