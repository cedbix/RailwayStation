using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace RailwayStation
{
    class GraphControl : FrameworkElement
    {
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            var position = e.GetPosition(this);

            MessageBox.Show($"X={position.X}; Y={position.Y}");
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), new Rect(0, 0, ActualWidth, ActualHeight));
            drawingContext.DrawRectangle(Brushes.Aqua, new Pen(Brushes.Black, 1), new Rect(20, 30, 100, 100));
        }


    }
}
