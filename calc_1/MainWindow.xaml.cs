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

namespace calc_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b;
        byte count;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + 9;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            a = double.Parse(CalcBox.Text);
            DopBox.Text = a.ToString() + "*";
            CalcBox.Clear();
            count = 3;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            a = double.Parse(CalcBox.Text);
            DopBox.Text = a.ToString() + "-";
            CalcBox.Clear();
            count = 2;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            switch (count)
            {
                case 1:
                    b = a + double.Parse(CalcBox.Text);
                    CalcBox.Text = b.ToString();
                    break;
                case 2:
                    b = a - double.Parse(CalcBox.Text);
                    CalcBox.Text = b.ToString();
                    break;

                case 3:
                    b = a * double.Parse(CalcBox.Text);
                    CalcBox.Text = b.ToString();
                    break;

                case 4:
                    if (double.Parse(CalcBox.Text) != 0)
                    {
                        b = a / double.Parse(CalcBox.Text);
                        CalcBox.Text = b.ToString();
                    }
                    if (double.Parse(CalcBox.Text) ==0)
                    {
                        MessageBox.Show("На 0 делить нельзя");
                    }
                  
                    break;
                default:
                    break;
            }
            DopBox.Clear();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            CalcBox.Text = CalcBox.Text + ",";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            CalcBox.Clear();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            a = double.Parse(CalcBox.Text);

            CalcBox.Clear();
            DopBox.Text = a.ToString() + "/";
            count = 4;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            a = double.Parse(CalcBox.Text);
            DopBox.Text = a.ToString() + "+";
            CalcBox.Clear();
            count = 1;
        }
    }
}
