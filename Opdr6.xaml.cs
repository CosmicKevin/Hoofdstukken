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
    /// Interaction logic for Opdr6.xaml
    /// </summary>
    public partial class Opdr6 : Window
    {
        public Opdr6()
        {
            InitializeComponent();
            DrawStreet(draw, new SolidColorBrush(Colors.Black), 10, 10, 50, 50);
        }

        private void DrawStreet(Canvas draw, SolidColorBrush brush, double topRoofX, double topRoofY, double width, double height)
        {
            for (int i = 0; i < 4; i++)
            {
                DrawHouse(draw, brush, topRoofX, topRoofY, width, height);
                topRoofX = topRoofX + width + 20;
            }
        }

        private void DrawHouse(Canvas draw, SolidColorBrush brush, double topRoofX, double topRoofY, double width, double height)
        {
                DrawTriangle(draw, brush, topRoofX, topRoofY, width, height);
                DrawRectangle(draw, brush, topRoofX, topRoofY + height, width, height);
        }

        private void DrawTriangle(Canvas draw, SolidColorBrush brush, double topX, double topY, double width, double height)
        {
            double rightcornerX, rightcornerY;
            rightcornerX = topX + width;
            rightcornerY = topY + width;

            DrawLine(draw, brush, topX, topY, topX, rightcornerY);
            DrawLine(draw, brush, topX, rightcornerY, rightcornerX, rightcornerY);
            DrawLine(draw, brush, topX, topY, rightcornerX, rightcornerY);
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

        private void DrawRectangle(Canvas drawingArea, SolidColorBrush brush, double topleftX, double topLeftY, double width, double height)
        {
            Rectangle huis = new Rectangle();
            huis.Width = width;
            huis.Height = height;
            huis.Margin = new Thickness(topleftX, topLeftY, 0, 0);
            huis.Stroke = brush;
            drawingArea.Children.Add(huis);
        }
    }
}
