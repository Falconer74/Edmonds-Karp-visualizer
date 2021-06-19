using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FordFulkersonVisualization
{
    public class Graph
    {
        public ObservableCollection<Vertex> Vertices { get; set; }
        public SourceVertex Source { get; set; }
        public SinkVertex Sink { get; set; }
        public ObservableCollection<Edge> Edges { get; set; }

        public Graph()
        {
            Vertices = new ObservableCollection<Vertex>();
            Edges = new ObservableCollection<Edge>();
            Source = null;
            Sink = null;
        }

        public void AddSource(SourceVertex source)
        {
            if(Source != null)
            {
                foreach (Edge edge in source.OutcomingEdges)
                {
                    edge.SecondVertex.IncomingEdges.Remove(edge);
                    Edges.Remove(edge);
                }
                Vertices.Remove(source);
            }

            Vertices.Add(source);
            Source = source;
        }

        public void AddSink(SinkVertex sink)
        {
            if (sink != null)
            {
                foreach(Edge edge in sink.IncomingEdges)
                {
                    edge.FirstVertex.OutcomingEdges.Remove(edge);
                    Edges.Remove(edge);
                }
                Vertices.Remove(sink);
            }

            Vertices.Add(sink);
            Sink = sink;
        }

        public void AddResidualEdges()
        {
            List<Edge> newEdges = new List<Edge>();
            foreach(Edge e in Edges)
            {
                Vertex fv = e.FirstVertex;
                Vertex sv = e.SecondVertex;

                ResidualEdges newEdge = new ResidualEdges()
                {
                    FirstVertex = sv,
                    SecondVertex = fv,
                    Capacity = 0
                };

                e.ResidualEdge = newEdge;
                newEdge.ResidualEdge = e;


                sv.OutcomingEdges.Add(newEdge);
                fv.IncomingEdges.Add(newEdge);

                newEdges.Add(newEdge);
            }

            foreach(Edge e in newEdges)
            {
                Edges.Add(e);
            }
        }

        public void AddVertex(Vertex vertex)
        {
            Vertices.Add(vertex);
        }

        public void AddEdge(Edge edge)
        {
            Edges.Add(edge);
            edge.FirstVertex.OutcomingEdges.Add(edge);
            edge.SecondVertex.IncomingEdges.Add(edge);
        }
    }
}
