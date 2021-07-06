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
    /// Interaction logic for Opdr4.xaml
    /// </summary>
    public partial class Opdr4 : Window
    {
        public Opdr4()
        {
            InitializeComponent();
            DrawCircle(drawArea, new SolidColorBrush(Colors.Red), 10, 10, 100);
        }

        private void DrawCircle(Canvas drawArea, SolidColorBrush brush, double xCentre, double yCentre, double radius)
        {
            Ellipse rondje = new Ellipse();
            rondje.Width = radius * 2;
            rondje.Height = radius * 2;
            rondje.Margin = new Thickness(xCentre, yCentre, 0, 0);
            rondje.Stroke = brush;
            drawArea.Children.Add(rondje);
        }
    }
}
