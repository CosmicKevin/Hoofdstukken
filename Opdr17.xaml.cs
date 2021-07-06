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
    /// Interaction logic for Opdr17.xaml
    /// </summary>
    public partial class Opdr17 : Window
    {
        public Opdr17()
        {
            InitializeComponent();
            MessageBox.Show("Er is " + CalculateTimeDifferenceInSeconds(3, 3, 3, 1, 1, 2).ToString() + " seconde verschil");
        }

        public int CalculateTimeDifferenceInSeconds(int uur, int minuut, int seconde, int uur2, int minuut2, int seconde2)
        {
            uur = uur * 3600;
            minuut = minuut * 60;
            int numberOfSeconds = (uur + minuut + seconde);

            uur2 = uur2 * 3600;
            minuut2 = minuut2 * 60;
            int numberOfSeconds2 = (uur2 + minuut2 + seconde2);

            int verschil = numberOfSeconds - numberOfSeconds2;
            return verschil;
        }
    }
}
