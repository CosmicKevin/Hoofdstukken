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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hoofdstuk5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btn1.Click += new RoutedEventHandler(btn1_Click);
            btn2.Click += new RoutedEventHandler(btn2_Click);
            btn3.Click += new RoutedEventHandler(btn3_Click);
            btn4.Click += new RoutedEventHandler(btn4_Click);
            btn5.Click += new RoutedEventHandler(btn5_Click);
            btn6.Click += new RoutedEventHandler(btn6_Click);
            btn7.Click += new RoutedEventHandler(btn7_Click);

            btn8.Click += new RoutedEventHandler(btn8_Click);
            btn9.Click += new RoutedEventHandler(btn9_Click);
            btn10.Click += new RoutedEventHandler(btn10_Click);
            btn11.Click += new RoutedEventHandler(btn11_Click);
            btn12.Click += new RoutedEventHandler(btn12_Click);
            btn13.Click += new RoutedEventHandler(btn13_Click);
            btn14.Click += new RoutedEventHandler(btn14_Click);

            btn15.Click += new RoutedEventHandler(btn15_Click);
            btn16.Click += new RoutedEventHandler(btn16_Click);
            btn17.Click += new RoutedEventHandler(btn17_Click);
            btn18.Click += new RoutedEventHandler(btn18_Click);
            btn19.Click += new RoutedEventHandler(btn19_Click);
            btn20.Click += new RoutedEventHandler(btn20_Click);
            btn21.Click += new RoutedEventHandler(btn21_Click);

            btn22.Click += new RoutedEventHandler(btn22_Click);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Opdr1 game = new Opdr1();
            game.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Opdr2 game = new Opdr2();
            game.Show();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Opdr3 game = new Opdr3();
            game.Show();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Opdr4 game = new Opdr4();
            game.Show();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Opdr5 game = new Opdr5();
            game.Show();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Opdr6 game = new Opdr6();
            game.Show();
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Opdr7 game = new Opdr7();
            game.Show();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Opdr8 game = new Opdr8();
            game.Show();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Opdr9 game = new Opdr9();
            game.Show();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            Opdr10 game = new Opdr10();
            game.Show();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            Opdr11 game = new Opdr11();
            game.Show();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            Opdr12 game = new Opdr12();
            game.Show();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            Opdr13 game = new Opdr13();
            game.Show();
        }
        private void btn14_Click(object sender, EventArgs e)
        {
            Opdr14 game = new Opdr14();
            game.Show();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Opdr15 game = new Opdr15();
            game.Show();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            Opdr16 game = new Opdr16();
            game.Show();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            Opdr17 game = new Opdr17();
            game.Show();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            Opdr18 game = new Opdr18();
            game.Show();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            Opdr19 game = new Opdr19();
            game.Show();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            Opdr20 game = new Opdr20();
            game.Show();
        }
        private void btn21_Click(object sender, EventArgs e)
        {
            Opdr21 game = new Opdr21();
            game.Show();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            Opdr22 game = new Opdr22();
            game.Show();
        }
    }
    }
