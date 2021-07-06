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
    /// Interaction logic for Opdr2.xaml
    /// </summary>
    public partial class Opdr2 : Window
    {
        public Opdr2()
        {
            InitializeComponent();
            ShowName("Kevin", "van Esdonk");
        }

        public void ShowName(string naam1, string naam2)
        {
            MessageBox.Show(naam1);
            MessageBox.Show(naam2);
        }
    }
}
