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
    /// Interaction logic for Opdr3.xaml
    /// </summary>
    public partial class Opdr3 : Window
    {
        public Opdr3()
        {
            InitializeComponent();
            ShowSalary(160000, 8);
        }

        public void ShowSalary(int Getal1, int Getal2)
        {
            int Getal3 = Getal1 * Getal2;
            MessageBox.Show(Getal3.ToString());
        }
    }
}
