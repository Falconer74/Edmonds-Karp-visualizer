using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordFulkersonVisualization
{
    public class Path
    {
        public List<Edge> Edges;
        public Path()
        {
            Edges = new List<Edge>();
        }

        public void MarkPath()
        {
            foreach(Edge e in Edges)
            {
                e.Status = EdgeStatus.Choosen;
            }
        }

        public void IncreaseFlow(int flow)
        {
            foreach(Edge e in Edges)
            {
                e.IncreaseFlow(flow);
            }
        }
    }
}
