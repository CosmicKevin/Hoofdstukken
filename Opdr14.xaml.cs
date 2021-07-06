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
    /// Interaction logic for Opdr14.xaml
    /// </summary>
    public partial class Opdr14 : Window
    {
        public Opdr14()
        {
            InitializeComponent();
            ConvertNumberToBinary(12);
        }

        private int ConvertNumberToBinary(int nummer)
        {
            MessageBox.Show("Binaire string: " + Convert.ToString(nummer, 2));
            return nummer;
        }
    }
}
