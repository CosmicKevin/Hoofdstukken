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
    /// Interaction logic for Opdr22.xaml
    /// </summary>
    public partial class Opdr22 : Window
    {
        public Opdr22()
        {
            InitializeComponent();
            MessageBox.Show(Increment(4).ToString());
        }

        private int Increment(int nummer)
        {
            return nummer + 1;
        }
        private double Increment(double nummer)
        {
            return nummer;
        }
        private string Increment(string nummer)
        {
            nummer = nummer + "";
            return nummer;
        }
    }
}
