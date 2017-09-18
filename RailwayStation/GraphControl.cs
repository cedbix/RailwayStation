﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System;

namespace RailwayStation
{
    class GraphControl : FrameworkElement
    {
        private Graph<MyPoint> graph;

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            //var position = e.GetPosition(this);
            //MessageBox.Show($"X={position.X}; Y={position.Y}");
            //GraphNode<MyPoint> n1 = new GraphNode<MyPoint>(new MyPoint(1, 50));
            //GraphNode<MyPoint> n2 = new GraphNode<MyPoint>(new MyPoint(0, 50));
            //MessageBox.Show(n1.Value.Equals(n2.Value) ? "true" : "false");
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            initGraph();
            foreach (GraphNode<MyPoint> node in graph.Nodes)
            {
                foreach (GraphNode<MyPoint> neighbor in node.Neighbors)
                    drawingContext.DrawLine(new Pen(Brushes.Gray, 1), new Point(node.Value.X, node.Value.Y), new Point(neighbor.Value.X, neighbor.Value.Y));

                if (node.Neighbors.Count > 2)
                    drawingContext.DrawEllipse(Brushes.Red, new Pen(Brushes.DarkSlateGray, 1), new Point(node.Value.X, node.Value.Y), 2, 2);
            }

        }

        protected void initGraph()
        {
            graph = new Graph<MyPoint>();

            // Path 1
            GraphNode<MyPoint> n0_50 = new GraphNode<MyPoint>(new MyPoint(0, 50));
            GraphNode<MyPoint> n20_30 = new GraphNode<MyPoint>(new MyPoint(20, 30));
            GraphNode<MyPoint> n40_30 = new GraphNode<MyPoint>(new MyPoint(40, 30));
            GraphNode<MyPoint> n50_40 = new GraphNode<MyPoint>(new MyPoint(50, 40));
            GraphNode<MyPoint> n60_50 = new GraphNode<MyPoint>(new MyPoint(60, 50));
            GraphNode<MyPoint> n70_60 = new GraphNode<MyPoint>(new MyPoint(70, 60));
            GraphNode<MyPoint> n80_70 = new GraphNode<MyPoint>(new MyPoint(80, 70));
            GraphNode<MyPoint> n90_80 = new GraphNode<MyPoint>(new MyPoint(90, 80));
            GraphNode<MyPoint> n100_90 = new GraphNode<MyPoint>(new MyPoint(100, 90));
            GraphNode<MyPoint> n150_140 = new GraphNode<MyPoint>(new MyPoint(150, 140));
            GraphNode<MyPoint> n250_90 = new GraphNode<MyPoint>(new MyPoint(250, 90));
            GraphNode<MyPoint> n260_100 = new GraphNode<MyPoint>(new MyPoint(260, 100));
            GraphNode<MyPoint> n410_30 = new GraphNode<MyPoint>(new MyPoint(410, 30));
            GraphNode<MyPoint> n410_50 = new GraphNode<MyPoint>(new MyPoint(410, 50));
            GraphNode<MyPoint> n410_70 = new GraphNode<MyPoint>(new MyPoint(410, 70));
            GraphNode<MyPoint> n420_40 = new GraphNode<MyPoint>(new MyPoint(420, 40));
            GraphNode<MyPoint> n420_60 = new GraphNode<MyPoint>(new MyPoint(420, 60));
            GraphNode<MyPoint> n420_80 = new GraphNode<MyPoint>(new MyPoint(420, 80));
            GraphNode<MyPoint> n420_100 = new GraphNode<MyPoint>(new MyPoint(420, 100));
            GraphNode<MyPoint> n430_90 = new GraphNode<MyPoint>(new MyPoint(430, 90));
            GraphNode<MyPoint> n440_40 = new GraphNode<MyPoint>(new MyPoint(440, 40));
            GraphNode<MyPoint> n440_80 = new GraphNode<MyPoint>(new MyPoint(440, 80));
            GraphNode<MyPoint> n460_60 = new GraphNode<MyPoint>(new MyPoint(460, 60));
            GraphNode<MyPoint> n470_60 = new GraphNode<MyPoint>(new MyPoint(470, 60));
            GraphNode<MyPoint> n490_80 = new GraphNode<MyPoint>(new MyPoint(490, 80));
            GraphNode<MyPoint> n500_80 = new GraphNode<MyPoint>(new MyPoint(500, 80));
            GraphNode<MyPoint> n90_10 = new GraphNode<MyPoint>(new MyPoint(90, 10));
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
            GraphNode<MyPoint> n0_30 = new GraphNode<MyPoint>(new MyPoint(0, 30));
            GraphNode<MyPoint> n15_20 = new GraphNode<MyPoint>(new MyPoint(15, 20));
            GraphNode<MyPoint> n20_0 = new GraphNode<MyPoint>(new MyPoint(20, 0));
            graph.AddNode(n0_30);
            graph.AddNode(n15_20);
            graph.AddNode(n20_0);
            graph.AddDirectedEdge(n0_30, n15_20, 1);
            graph.AddDirectedEdge(n15_20, n20_0, 1);

            // Path 3
            GraphNode<MyPoint> n0_110 = new GraphNode<MyPoint>(new MyPoint(0, 110));
            GraphNode<MyPoint> n110_110 = new GraphNode<MyPoint>(new MyPoint(110, 110));
            GraphNode<MyPoint> n140_140 = new GraphNode<MyPoint>(new MyPoint(140, 140));
            graph.AddNode(n0_110);
            graph.AddNode(n110_110);
            graph.AddNode(n140_140);
            graph.AddDirectedEdge(n0_110, n110_110, 1);
            graph.AddDirectedEdge(n110_110, n140_140, 1);
        }

    }
}
