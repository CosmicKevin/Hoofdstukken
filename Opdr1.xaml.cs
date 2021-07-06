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
    /// Interaction logic for Opdr1.xaml
    /// </summary>
    public partial class Opdr1 : Window
    {
        public Opdr1()
        {
            InitializeComponent();
            ShowName("Kevin");
        }

        public void ShowName(string naam)
        {
            MessageBox.Show(naam);
        }
    }
}
