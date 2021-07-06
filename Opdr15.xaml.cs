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
    /// Interaction logic for Opdr15.xaml
    /// </summary>
    public partial class Opdr15 : Window
    {
        public Opdr15()
        {
            InitializeComponent();
            ConvertSecondsToHoursMinutesSeconds(3662);
        }

        static void ConvertSecondsToHoursMinutesSeconds(int seconds)
        {
            TimeSpan tijd = TimeSpan.FromSeconds(seconds);
            MessageBox.Show(string.Format("{0:D2} ur(en): {1:D2} minut(en): {2:D2} second(en)",
            tijd.Hours,
            tijd.Minutes,
            tijd.Seconds));
        }
    }
}
