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
    /// Interaction logic for Opdr10.xaml
    /// </summary>
    public partial class Opdr10 : Window
    {
        public Opdr10()
        {
            InitializeComponent();
            MessageBox.Show(CalculateCircleArea(1.25).ToString());
        }
        public double CalculateCircleArea(double straal)
        {
            double cirkelopp = Math.PI * straal * straal;
            return cirkelopp;
        }
    }
}
