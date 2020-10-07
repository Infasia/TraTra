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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Calc cl = new Calc();

        public void Sum_Button(object sender, RoutedEventArgs e)
        {
            // XAAFKEQJGOEQJNKGOQKEGNAGJOAEJ
            int a;
            int b;
            if (A.Text != "" && B.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(A.Text);
                    b = Convert.ToInt32(B.Text);
                    result.Content = Convert.ToString(cl.sum(a, b));
                }
                catch
                {
                    MessageBox.Show($"error in text is bykVA");
                }
            }
            else
                MessageBox.Show("Write numer");
        }

        private void Minus_Button(object sender, RoutedEventArgs e)
        {
            int a;
            int b;

            if (A.Text != "" && B.Text != "")
            {

                try
                {
                    a = Convert.ToInt32(A.Text);
                    b = Convert.ToInt32(B.Text);
                    result.Content = Convert.ToString(cl.minus(a, b)); 
                }
                catch 
                {
                    MessageBox.Show("Error");
                }
            }
            else
                MessageBox.Show("Write numer");
        }

        private void Multy_Button(object sender, RoutedEventArgs e)
        {
            int a;
            int b;
            if (A.Text != "" && B.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(A.Text);
                    b = Convert.ToInt32(B.Text);
                    result.Content = Convert.ToString(cl.multy(a, b));
                }
                catch
                {
                    MessageBox.Show($"error in text is bykVA");
                }
            }
            else
                MessageBox.Show("Write numer");
        }

        private void Devide_Click(object sender, RoutedEventArgs e)
        {
            int a;
            int b;
            if (A.Text != "" && B.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(A.Text);
                    b = Convert.ToInt32(B.Text);
                    result.Content = Convert.ToString(cl.multy(a, b));
                }
                catch
                {
                    MessageBox.Show($"error in text is bykVA");
                }
            }
            else
                MessageBox.Show("Write numer");
        }
    }
}
