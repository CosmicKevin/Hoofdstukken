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
    /// Interaction logic for Opdr19.xaml
    /// </summary>
    public partial class Opdr19 : Window
    {
        public Opdr19()
        {
            InitializeComponent();
            int v = 4;
            Increment(ref v);
        }

        private void Increment(ref int v)
        {
            v++;
            MessageBox.Show(Convert.ToString(v));
        }
    }
}
