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
    /// Interaction logic for Opdr21.xaml
    /// </summary>
    public partial class Opdr21 : Window
    {
        public Opdr21()
        {
            InitializeComponent();
            MessageBox.Show(GetTimeInSeconds(1, 1, 2, 1, 2).ToString());
        }
        public int GetTimeInSeconds(int uur, int minuut, int seconde, int minuut2, int seconde2)
        {
            uur = uur * 3600;
            minuut = minuut * 60;
            int numberOfSeconds = (uur + minuut + seconde);
            int tweedetijd = (minuut2 + seconde2);
            int beide = numberOfSeconds + tweedetijd;
            return beide;
        }

    }
}
