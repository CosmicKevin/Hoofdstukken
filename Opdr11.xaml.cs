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
    /// Interaction logic for Opdr11.xaml
    /// </summary>
    public partial class Opdr11 : Window
    {
        public Opdr11()
        {
            InitializeComponent();
            MessageBox.Show(GetTimeInSeconds(1, 1, 2).ToString());
        }
        public int GetTimeInSeconds(int uur, int minuut, int seconde)
        {
            uur = uur * 3600;
            minuut = minuut * 60;
            int numberOfSeconds = (uur + minuut + seconde);
            return numberOfSeconds;
        }
    }
}
