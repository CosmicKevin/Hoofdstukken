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
    /// Interaction logic for Opdr12.xaml
    /// </summary>
    public partial class Opdr12 : Window
    {
        public Opdr12()
        {
            InitializeComponent();
            MessageBox.Show(CalculateCylinder(1.25, 5).ToString());
        }
        public double CalculateCircleArea(double straal)
        {
            double cirkelopp = Math.PI * straal * straal;
            return cirkelopp * 2;
        }

        public double CalculateCircleSide(double straal, double height)
        {
            double zijkantopp = 2 * Math.PI * straal * height;
            return zijkantopp;
        }

        public double CalculateCylinder(double straal, double height)
        {
            double CircleArea = CalculateCircleArea(straal) + CalculateCircleSide(straal, height);
            return CircleArea;
        }
    }
}
