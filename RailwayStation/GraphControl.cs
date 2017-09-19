using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System;
using System.Windows.Controls;
using System.Globalization;

namespace RailwayStation
{
    class GraphControl : FrameworkElement
    {

        public GraphControl() : base()
        {
            graph = new Graph<MyPoint>();
            park1 = new Graph<MyPoint>("Park 1");
            park2 = new Graph<MyPoint>("Park 2");
            park3 = new Graph<MyPoint>("Park 3");
            activeColor = Brushes.LightGreen;

            if (activePark == null)
                activePark = park1;

            initGraph();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawPark(drawingContext);
            drawGraph(drawingContext);
        }

        protected void initGraph()
        {
            // Path 1
            Node<MyPoint> n0_50 = new Node<MyPoint>(new MyPoint(0, 50));
            Node<MyPoint> n20_30 = new Node<MyPoint>(new MyPoint(20, 30));
            Node<MyPoint> n40_30 = new Node<MyPoint>(new MyPoint(40, 30));
            Node<MyPoint> n50_40 = new Node<MyPoint>(new MyPoint(50, 40));
            Node<MyPoint> n60_50 = new Node<MyPoint>(new MyPoint(60, 50));
            Node<MyPoint> n70_60 = new Node<MyPoint>(new MyPoint(70, 60));
            Node<MyPoint> n80_70 = new Node<MyPoint>(new MyPoint(80, 70));
            Node<MyPoint> n90_80 = new Node<MyPoint>(new MyPoint(90, 80));
            Node<MyPoint> n100_90 = new Node<MyPoint>(new MyPoint(100, 90));
            Node<MyPoint> n150_140 = new Node<MyPoint>(new MyPoint(150, 140));
            Node<MyPoint> n250_90 = new Node<MyPoint>(new MyPoint(250, 90));
            Node<MyPoint> n260_100 = new Node<MyPoint>(new MyPoint(260, 100));
            Node<MyPoint> n410_30 = new Node<MyPoint>(new MyPoint(410, 30));
            Node<MyPoint> n410_50 = new Node<MyPoint>(new MyPoint(410, 50));
            Node<MyPoint> n410_70 = new Node<MyPoint>(new MyPoint(410, 70));
            Node<MyPoint> n420_40 = new Node<MyPoint>(new MyPoint(420, 40));
            Node<MyPoint> n420_60 = new Node<MyPoint>(new MyPoint(420, 60));
            Node<MyPoint> n420_80 = new Node<MyPoint>(new MyPoint(420, 80));
            Node<MyPoint> n420_100 = new Node<MyPoint>(new MyPoint(420, 100));
            Node<MyPoint> n430_90 = new Node<MyPoint>(new MyPoint(430, 90));
            Node<MyPoint> n440_40 = new Node<MyPoint>(new MyPoint(440, 40));
            Node<MyPoint> n440_80 = new Node<MyPoint>(new MyPoint(440, 80));
            Node<MyPoint> n460_60 = new Node<MyPoint>(new MyPoint(460, 60));
            Node<MyPoint> n470_60 = new Node<MyPoint>(new MyPoint(470, 60));
            Node<MyPoint> n490_80 = new Node<MyPoint>(new MyPoint(490, 80));
            Node<MyPoint> n500_80 = new Node<MyPoint>(new MyPoint(500, 80));
            Node<MyPoint> n90_10 = new Node<MyPoint>(new MyPoint(90, 10));

            graph.AddNode(n0_50);
            graph.AddNode(n20_30);
            graph.AddNode(n40_30);
            graph.AddNode(n50_40);
            graph.AddNode(n60_50);
            graph.AddNode(n70_60);
            graph.AddNode(n80_70);
            graph.AddNode(n90_80);
            graph.AddNode(n100_90);
            graph.AddNode(n150_140);
            graph.AddNode(n250_90);
            graph.AddNode(n260_100);
            graph.AddNode(n410_30);
            graph.AddNode(n410_50);
            graph.AddNode(n410_70);
            graph.AddNode(n420_40);
            graph.AddNode(n420_60);
            graph.AddNode(n420_80);
            graph.AddNode(n420_100);
            graph.AddNode(n430_90);
            graph.AddNode(n440_40);
            graph.AddNode(n440_80);
            graph.AddNode(n460_60);
            graph.AddNode(n470_60);
            graph.AddNode(n490_80);
            graph.AddNode(n500_80);

            graph.AddDirectedEdge(n0_50, n20_30, 1);
            graph.AddDirectedEdge(n20_30, n40_30, 1);
            graph.AddDirectedEdge(n40_30, n50_40, 1);
            graph.AddDirectedEdge(n40_30, n410_30, 1);
            graph.AddDirectedEdge(n50_40, n60_50, 1);
            graph.AddDirectedEdge(n50_40, n420_40, 1);
            graph.AddDirectedEdge(n60_50, n70_60, 1);
            graph.AddDirectedEdge(n60_50, n410_50, 1);
            graph.AddDirectedEdge(n70_60, n80_70, 1);
            graph.AddDirectedEdge(n70_60, n420_60, 1);
            graph.AddDirectedEdge(n80_70, n90_80, 1);
            graph.AddDirectedEdge(n80_70, n410_70, 1);
            graph.AddDirectedEdge(n90_80, n100_90, 1);
            graph.AddDirectedEdge(n90_80, n420_80, 1);
            graph.AddDirectedEdge(n100_90, n150_140, 1);
            graph.AddDirectedEdge(n100_90, n250_90, 1);
            graph.AddDirectedEdge(n250_90, n430_90, 1);
            graph.AddDirectedEdge(n250_90, n260_100, 1);
            graph.AddDirectedEdge(n260_100, n420_100, 1);
            graph.AddDirectedEdge(n410_30, n420_40, 1);
            graph.AddDirectedEdge(n420_40, n440_40, 1);
            graph.AddDirectedEdge(n410_50, n420_60, 1);
            graph.AddDirectedEdge(n410_70, n420_80, 1);
            graph.AddDirectedEdge(n420_60, n460_60, 1);
            graph.AddDirectedEdge(n420_80, n440_80, 1);
            graph.AddDirectedEdge(n420_100, n430_90, 1);
            graph.AddDirectedEdge(n430_90, n440_80, 1);
            graph.AddDirectedEdge(n440_40, n460_60, 1);
            graph.AddDirectedEdge(n440_80, n490_80, 1);
            graph.AddDirectedEdge(n460_60, n470_60, 1);
            graph.AddDirectedEdge(n470_60, n490_80, 1);
            graph.AddDirectedEdge(n490_80, n500_80, 1);

            // Path 2
            Node<MyPoint> n0_30 = new Node<MyPoint>(new MyPoint(0, 30));
            Node<MyPoint> n15_20 = new Node<MyPoint>(new MyPoint(15, 20));
            Node<MyPoint> n20_0 = new Node<MyPoint>(new MyPoint(20, 0));
            graph.AddNode(n0_30);
            graph.AddNode(n15_20);
            graph.AddNode(n20_0);
            graph.AddDirectedEdge(n0_30, n15_20, 1);
            graph.AddDirectedEdge(n15_20, n20_0, 1);

            // Path 3
            Node<MyPoint> n0_110 = new Node<MyPoint>(new MyPoint(0, 110));
            Node<MyPoint> n110_110 = new Node<MyPoint>(new MyPoint(110, 110));
            Node<MyPoint> n140_140 = new Node<MyPoint>(new MyPoint(140, 140));
            graph.AddNode(n0_110);
            graph.AddNode(n110_110);
            graph.AddNode(n140_140);
            graph.AddDirectedEdge(n0_110, n110_110, 1);
            graph.AddDirectedEdge(n110_110, n140_140, 1);

            // Park 1
            park1.AddNode(n40_30);
            park1.AddNode(n70_60);
            park1.AddNode(n460_60);
            park1.AddNode(n440_40);
            park1.AddNode(n420_40);
            park1.AddNode(n410_30);

            // Park 2
            park2.AddNode(n70_60);
            park2.AddNode(n470_60);
            park2.AddNode(n490_80);
            park2.AddNode(n440_80);
            park2.AddNode(n420_100);
            park2.AddNode(n260_100);
            park2.AddNode(n250_90);
            park2.AddNode(n100_90);

            // Park 3
            park3.AddNode(n40_30);
            park3.AddNode(n100_90);
            park3.AddNode(n250_90);
            park3.AddNode(n260_100);
            park3.AddNode(n420_100);
            park3.AddNode(n440_80);
            park3.AddNode(n490_80);
            park3.AddNode(n470_60);
            park3.AddNode(n460_60);
            park3.AddNode(n440_40);
            park3.AddNode(n420_40);
            park3.AddNode(n410_30);
        }

        public void ChangePark(string park)
        {
            if (park.Equals("Park 1"))
                activePark = park1;
            else if (park.Equals("Park 2"))
                activePark = park2;
            else if (park.Equals("Park 3"))
                activePark = park3;
            this.InvalidateVisual();
        }

        public void ChangeColor(string park)
        {
            if (park.Equals("Green"))
                activeColor = Brushes.LightGreen;
            else if (park.Equals("Blue"))
                activeColor = Brushes.LightSkyBlue;
            else if (park.Equals("Orange"))
                activeColor = Brushes.Orange;
            this.InvalidateVisual();
        }

        private void drawGraph(DrawingContext drawingContext)
        {
            foreach (Node<MyPoint> node in graph.Nodes)
            {
                foreach (Node<MyPoint> neighbor in node.Neighbors)
                    drawingContext.DrawLine(new Pen(Brushes.Gray, 1), new Point(node.Value.X, node.Value.Y), new Point(neighbor.Value.X, neighbor.Value.Y));

                if (node.Neighbors.Count > 2)
                    drawingContext.DrawEllipse(Brushes.Red, new Pen(Brushes.DarkSlateGray, 1), new Point(node.Value.X, node.Value.Y), 2, 2);
            }
        }

        private void drawPark(DrawingContext drawingContext)
        {
            PathFigure path = new PathFigure();
            bool pathStarted = false;
           
            foreach (Node<MyPoint> node in activePark.Nodes)
            {
                if (!pathStarted)
                {
                    path.StartPoint = new Point(node.Value.X, node.Value.Y);
                    path.IsClosed = true;
                    pathStarted = true;
                }
                else
                {
                    LineSegment segment = new LineSegment();
                    segment.Point = new Point(node.Value.X, node.Value.Y);
                    path.Segments.Add(segment);
                }
            }

            PathGeometry geometry = new PathGeometry();
            geometry.Figures.Add(path);
            drawingContext.DrawGeometry(activeColor, new Pen(Brushes.Transparent, 1), geometry);

            // Draw park name
            Point center = findGraphCenter(activePark);
            center.X = center.X - 10;
            center.Y = center.Y - 10;
            FormattedText formattedText = new FormattedText(
               activePark.Name,
               CultureInfo.GetCultureInfo("en-us"),
               FlowDirection.LeftToRight,
               new Typeface("Verdana"),
               13,
               Brushes.Black);
            drawingContext.DrawText(formattedText, center);
        }

        private Point findGraphCenter(Graph<MyPoint> graph)
        {
            int minX = 0, maxX = 0, minY = 0, maxY = 0;
            bool pathStarted = false;
            foreach (Node<MyPoint> node in activePark.Nodes)
            {
                if (!pathStarted)
                {
                    minX = node.Value.X;
                    maxX = node.Value.X;
                    minY = node.Value.Y;
                    maxY = node.Value.Y;
                    pathStarted = true;
                }
                else
                {
                    if (node.Value.X < minX)
                        minX = node.Value.X;
                    else if (node.Value.X > maxX)
                        maxX = node.Value.X;

                    if (node.Value.Y < minY)
                        minY = node.Value.Y;
                    else if (node.Value.Y > maxY)
                        maxY = node.Value.Y;
                }
                
            }
            int x = Math.Abs((maxX + minX) / 2);
            int y = Math.Abs((maxY + minY) / 2);
            return new Point(x, y);
        }

        // All nodes and edges
        private Graph<MyPoint> graph;

        // Parks for painting
        private Graph<MyPoint> park1;
        private Graph<MyPoint> park2;
        private Graph<MyPoint> park3;

        // Link to active park
        private Graph<MyPoint> activePark;

        // Color to paint active park
        private SolidColorBrush activeColor;
    }
}
