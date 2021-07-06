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
    /// Interaction logic for Opdr8.xaml
    /// </summary>
    public partial class Opdr8 : Window
    {
        public Opdr8()
        {
            InitializeComponent();
            MessageBox.Show(CalculateEuroEquivalent(37.50).ToString());
        }
        public double CalculateEuroEquivalent(double dollar)
        {
            double euro = dollar * 0.61;
            return euro;
        }
    }
}
