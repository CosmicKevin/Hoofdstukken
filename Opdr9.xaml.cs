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
    /// Interaction logic for Opdr9.xaml
    /// </summary>
    public partial class Opdr9 : Window
    {
        public Opdr9()
        {
            InitializeComponent();
            MessageBox.Show(CalculateCubeVolume(1.2).ToString());
        }
        public double CalculateCubeVolume(double lengte)
        {
            double cube = lengte * 5 * 4;
            return cube;
        }

    }
}
