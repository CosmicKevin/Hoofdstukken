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
using System.Windows.Shapes;

namespace Hoofdstuk5
{
    /// <summary>
    /// Interaction logic for Opdr5.xaml
    /// </summary>
    public partial class Opdr5 : Window
    {
        public Opdr5()
        {
            InitializeComponent();
            DrawTriangle2(drawingArea, new SolidColorBrush(Colors.Red), 10, 10, 50, 50);
        }

        public void DrawTriangle2(Canvas drawingArea, SolidColorBrush brush, double topX, double topY, double width, double height)
        {
            double rightcornerX, rightcornerY;
            rightcornerX = topX + width;
            rightcornerY = topY + width;

            DrawLine(drawingArea, brush, topX, topY, topX, rightcornerY);
            DrawLine(drawingArea, brush, topX, rightcornerY, rightcornerX, rightcornerY);
            DrawLine(drawingArea, brush, topX, topY, rightcornerX, rightcornerY);
        }

        private void DrawLine(Canvas drawingArea, SolidColorBrush brush, double startX, double startY, double endX, double endY)
        {
            Line theLine = new Line();
            theLine.X1 = startX; theLine.X2 = endX;
            theLine.Y1 = startY; theLine.Y2 = endY;
            theLine.Stroke = brush;
            theLine.StrokeThickness = 1;
            drawingArea.Children.Add(theLine);
        }
    }
}
