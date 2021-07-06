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
    /// Interaction logic for Opdr18.xaml
    /// </summary>
    public partial class Opdr18 : Window
    {
        public Opdr18()
        {
            InitializeComponent();
            CalculateTimeDifferenceInHoursMinutesSeconds(7200, 2154).ToString();
        }

        static void ConvertSecondsToHoursMinutesSeconds(int seconds)
        {
            TimeSpan tijd = TimeSpan.FromSeconds(seconds);
            MessageBox.Show(string.Format("{0:D2} ur(en): {1:D2} minut(en): {2:D2} second(en)",
            tijd.Hours,
            tijd.Minutes,
            tijd.Seconds));
        }
        private int CalculateTimeDifferenceInHoursMinutesSeconds(int seconde, int seconde2)
        {
            int seconds = seconde - seconde2;
            ConvertSecondsToHoursMinutesSeconds(seconds);
            return seconds;
        }

    }
}
