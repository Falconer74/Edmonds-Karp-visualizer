using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FordFulkersonVisualization
{
    public enum DesignerMode
    {
        Default,
        Source,
        Sink,
        Vertex,
        Edge
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Graph graph;
        DesignerMode mode;
        Vertex firstVertex;
        Vertex secondVertex;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnLoad;
            mode = DesignerMode.Default;
            graph = new Graph();
            firstVertex = null;
            secondVertex = null;
            curStage = AlgoStage.AddResidualEdges;
        }

        private void OnLoad(object sender, RoutedEventArgs e)
        {
            graph = new Graph();

            //SourceVertex source = new SourceVertex();
            //source.XPos = 50;
            //source.YPos = 150;
            //SinkVertex sink = new SinkVertex();
            //sink.XPos = 250;
            //sink.YPos = 150;
            //Vertex v1 = new Vertex();
            //v1.XPos = 150;
            //v1.YPos = 50;
            //Vertex v2 = new Vertex();
            //v2.XPos = 150;
            //v2.YPos = 250;

            //Edge e1 = new Edge()
            //{
            //    FirstVertex = source,
            //    SecondVertex = v1,
            //    Flow = 7,
            //    Capacity = 13
            //};
            //PrimaryEdge e2 = new PrimaryEdge()
            //{
            //    FirstVertex = source,
            //    SecondVertex = v2,
            //    Flow = 7,
            //    Capacity = 13
            //};
            //PrimaryEdge e6 = new PrimaryEdge()
            //{
            //    FirstVertex = v2,
            //    SecondVertex = source,
            //    Flow = 7,
            //    Capacity = 13
            //};
            //Edge e3 = new Edge()
            //{
            //    FirstVertex = v1,
            //    SecondVertex = v2,
            //    Flow = 7,
            //    Capacity = 13
            //};
            //Edge e4 = new Edge()
            //{
            //    FirstVertex = v1,
            //    SecondVertex = sink,
            //    Flow = 7,
            //    Capacity = 13
            //};
            //Edge e5 = new Edge()
            //{
            //    FirstVertex = v2,
            //    SecondVertex = sink,
            //    Flow = 7,
            //    Capacity = 13
            //};

            //source.OutcomingEdges.Add(e1);
            //source.OutcomingEdges.Add(e2);
            //source.IncomingEdges.Add(e6);

            //v1.IncomingEdges.Add(e1);
            //v1.OutcomingEdges.Add(e3);
            //v1.OutcomingEdges.Add(e4);

            //v2.IncomingEdges.Add(e2);
            //v2.OutcomingEdges.Add(e5);
            //v2.OutcomingEdges.Add(e6);

            //sink.IncomingEdges.Add(e4);
            //sink.IncomingEdges.Add(e5);

            //graph.Vertices.Add(source);
            //graph.Vertices.Add(sink);
            //graph.Vertices.Add(v1);
            //graph.Vertices.Add(v2);

            //graph.Edges.Add(e1);
            //graph.Edges.Add(e2);
            //graph.Edges.Add(e3);
            //graph.Edges.Add(e4);
            //graph.Edges.Add(e5);
            //graph.Edges.Add(e6);

            CanvasSpace.DataContext = graph;
        }

        private void AddSourceButton_Click(object sender, RoutedEventArgs e)
        {
            mode = DesignerMode.Source;
        }

        private void AddSinkButton_Click(object sender, RoutedEventArgs e)
        {
            mode = DesignerMode.Sink;
        }

        private void AddVertexButton_Click(object sender, RoutedEventArgs e)
        {
            mode = DesignerMode.Vertex;
        }

        private void AddEdgeButton_Click(object sender, RoutedEventArgs e)
        {
            mode = DesignerMode.Edge;
        }

        private void CanvasSpace_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Point p = Mouse.GetPosition(CanvasSpace);
            switch (mode)
            {
                case DesignerMode.Source:
                    {
                        SourceVertex source = new SourceVertex()
                        {
                            Status = VertexStatus.Default,
                            XPos = (int)p.X,
                            YPos = (int)p.Y,
                        };
                        graph.AddSource(source);
                    }
                    break;
                case DesignerMode.Sink:
                    {
                        SinkVertex sink = new SinkVertex()
                        {
                            Status = VertexStatus.Default,
                            XPos = (int)p.X,
                            YPos = (int)p.Y,
                        };
                        graph.AddSink(sink);
                    }
                    break;
                case DesignerMode.Vertex:
                    {
                        Vertex vertex = new Vertex()
                        {
                            Status = VertexStatus.Default,
                            XPos = (int)p.X,
                            YPos = (int)p.Y,
                        };
                        graph.AddVertex(vertex);
                    }
                    break;
                case DesignerMode.Edge:
                    {
                        if(firstVertex != null && secondVertex != null)
                        {
                            var dialog = new EdgeCapacityDialog();

                            int capacity = 0;

                            if (dialog.ShowDialog() == true)
                            {
                                capacity = Int32.Parse(dialog.ResponseText);
                            }

                            Edge edge = new Edge()
                            {
                                Status = EdgeStatus.Default,
                                FirstVertex = firstVertex,
                                SecondVertex = secondVertex,
                                Capacity = capacity
                            };

                            firstVertex.OutcomingEdges.Add(edge);
                            secondVertex.IncomingEdges.Add(edge);

                            graph.Edges.Add(edge);

                            firstVertex.Status = VertexStatus.Default;
                            secondVertex.Status = VertexStatus.Default;

                            firstVertex = null;
                            secondVertex = null;
                        }
                    }
                    break;
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Vertex v = (((Ellipse)(sender)).DataContext as Vertex);
            if (v.Status == VertexStatus.Choosen)
            {
                v.Status = VertexStatus.Default;
                if (v == firstVertex)
                {
                    firstVertex = null;
                }
                return;
            }
            if (firstVertex == null)
            {
                firstVertex = v;
                v.Status = VertexStatus.Choosen;
                return;
            }
            if (secondVertex == null) {
                secondVertex = v;
                v.Status = VertexStatus.Choosen;
                return;
            }
        }

        public enum AlgoStage
        {
            AddResidualEdges,
            FirstBFS,
            BFS,
            FindBottleneck,
            IncreaseFlow
        }

        AlgoStage curStage;

        public bool bfsIteration(Queue<Vertex> vertices)
        {
            Vertex v = vertices.Dequeue();

            foreach (Edge e in v.OutcomingEdges)
            {
                if (e.SecondVertex.Status == VertexStatus.Default && e.Capacity - e.Flow > 0)
                {
                    e.SecondVertex.Status = VertexStatus.Inspected;
                    prev.Add(e.SecondVertex, e);
                    if(e.SecondVertex == graph.Sink)
                    {
                        return true;
                    }

                    
                    vertices.Enqueue(e.SecondVertex);
                }
            }

            return false;
        }

        Queue<Vertex> queue;
        Dictionary<Vertex, Edge> prev;
        Path path;
        int bottleneck = 0;
        protected void EdmondsKarp()
        {
            switch (curStage)
            {
                case AlgoStage.AddResidualEdges:
                    graph.AddResidualEdges();
                    curStage = AlgoStage.FirstBFS;
                    break;
                case AlgoStage.FirstBFS:
                    queue = new Queue<Vertex>();
                    queue.Enqueue(graph.Source);
                    graph.Source.Status = VertexStatus.Inspected;
                    prev = new Dictionary<Vertex, Edge>();
                    prev.Add(graph.Source, null);

                    if (bfsIteration(queue))
                    {
                        curStage = AlgoStage.FindBottleneck;
                    }
                    else
                    {
                        if(queue.Count == 0)
                        {
                            int maxFlow = 0;

                            foreach(Edge e in graph.Sink.IncomingEdges)
                            {
                                maxFlow += e.Flow;
                            }

                            MessageBox.Show("Maximum flow found: " + maxFlow);

                            DeleteGraph();
                        }
                        curStage = AlgoStage.BFS;
                    }

                    break;
                case AlgoStage.BFS:
                    if (bfsIteration(queue))
                    {
                        curStage = AlgoStage.FindBottleneck;

                        path = new Path();

                        Edge edge = prev[graph.Sink];
                        while (edge != null)
                        {
                            path.Edges.Add(edge);
                            Vertex v = edge.FirstVertex;
                            edge = prev[v];
                        }

                        path.MarkPath();
                    }
                    else
                    {
                        if (queue.Count == 0)
                        {
                            int maxFlow = 0;

                            foreach (Edge e in graph.Sink.IncomingEdges)
                            {
                                maxFlow += e.Flow;
                            }

                            MessageBox.Show("Maximum flow found: " + maxFlow);

                            DeleteGraph();
                        }
                    }
                    break;
                case AlgoStage.FindBottleneck:
                    {
                        bottleneck = path.Edges[0].Capacity - path.Edges[0].Flow;
                        Edge bottleneckEdge;
                        foreach(Edge e in path.Edges)
                        {
                            if(e.Capacity - e.Flow < bottleneck)
                            {
                                bottleneck = e.Capacity - e.Flow;
                                bottleneckEdge = e;
                            }
                        }

                        curStage = AlgoStage.IncreaseFlow;
                    }
                    break;
                case AlgoStage.IncreaseFlow:
                    path.IncreaseFlow(bottleneck);
                    
                    foreach(Vertex v in graph.Vertices)
                    {
                        v.Status = VertexStatus.Default;
                    }

                    foreach (Edge e in graph.Edges)
                    {
                        if(e.Status == EdgeStatus.Choosen)
                        {
                            e.Status = EdgeStatus.Default;
                        }
                    }

                    bottleneck = 0;
                    path = new Path();
                    queue = new Queue<Vertex>();
                    prev = new Dictionary<Vertex, Edge>();

                    curStage = AlgoStage.FirstBFS;
                    

                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(graph.Source == null)
            {
                MessageBox.Show("Add source first");
                return;
            }
            if (graph.Sink == null)
            {
                MessageBox.Show("Add sink first");
                return;
            }

            (sender as Button).Content = "Next step";

            EdmondsKarp();
        }

        private void DeleteGraph()
        {
            RunAlgoButton.Visibility = Visibility.Collapsed;
            DeleteGraphButton.Visibility = Visibility.Visible;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            graph = new Graph();

            queue = new Queue<Vertex>();
            prev = new Dictionary<Vertex, Edge>();
            path = new Path();
            bottleneck = 0;

            curStage = AlgoStage.AddResidualEdges;

            CanvasSpace.DataContext = graph;

            RunAlgoButton.Visibility = Visibility.Visible;
            RunAlgoButton.Content = "Run Algorithm";
            DeleteGraphButton.Visibility = Visibility.Collapsed;
        }
    }
}
