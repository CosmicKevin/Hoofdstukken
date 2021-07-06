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
using System.Text.RegularExpressions;

namespace Hoofdstuk5
{
    /// <summary>
    /// Interaction logic for Opdr16.xaml
    /// </summary>
    public partial class Opdr16 : Window
    {
        public Opdr16()
        {
            InitializeComponent();
            btn1.Click += new RoutedEventHandler(btn1_Click);
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(txb1.Text);
            int num2 = Convert.ToInt32(txb2.Text);
            int num3 = Convert.ToInt32(txb3.Text);
            GetInput3(num1, num2, num3);
        }
        private int GetInput3(int num1, int num2, int num3)
        {
            int nummer = num1;
            MessageBox.Show(string.Format("Getal1: " + num1.ToString() + ", Getal2: " + num2.ToString() + ", Getal3: " + num3.ToString()));
            return nummer;
        }
    }
}
