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
using System.Windows.Media.Animation;
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
                    result.Content = Convert.ToString(cl.devide(a, b));
                }
                catch
                {
                    MessageBox.Show($"error in text is bykVA");
                }
            }
            else
                MessageBox.Show("Write numer");
        }

        private void sq_click(object sender, RoutedEventArgs e )
        {
            int a;
            if (A.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(A.Text);
                    result.Content = cl.sq(a);
                }
                catch
                {
                    MessageBox.Show($"error in text is bykVA");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void kvak_Click(object sender, RoutedEventArgs e)
        {
            double a;
            double b;
            if (A.Text != "" && B.Text != "")
            {
                try
                {
                    a = Convert.ToDouble(A.Text);
                    b = Convert.ToDouble(B.Text);
                    result.Content = cl.kva(a, b);
                }
                catch
                {
                    MessageBox.Show($"error in text is bykVA");
                }
            }
        }

        private void sin_click(object sender, RoutedEventArgs e)
        {
            int a;
            if (A.Text != "")
            {
                try
                {
                    a = Convert.ToInt32(A.Text);
                    result.Content = cl.sin(a);
                }
                catch
                {
                    MessageBox.Show($"error in text is bykVA");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void cos_click(object sender, RoutedEventArgs e)
        {
            int a;
            a = Convert.ToInt32(A.Text);
            result.Content = cl.cos(a);
        }

        private void tan_click(object sender, RoutedEventArgs e)
        {
            int a;
            a = Convert.ToInt32(A.Text);
            result.Content = cl.tan(a);
        }

        private void sec_click(object sender, RoutedEventArgs e)
        {
            int a;
            a = Convert.ToInt32(A.Text);
            result.Content = cl.sec(a);
        }

        private void cot_click(object sender, RoutedEventArgs e)
        {
            int a;
            a = Convert.ToInt32(A.Text);
            result.Content = cl.cot(a);
        }

        private void read_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Там где надо 1 число вводить его в поле А !!!!!");
        }

        private void ln_click(object sender, RoutedEventArgs e)
        {
            int a;
            a = Convert.ToInt32(A.Text);
            result.Content = cl.ln(a);
        }

        private void csc_click(object sender, RoutedEventArgs e)
        {
            int a;
            a = Convert.ToInt32(A.Text);
            result.Content = cl.csc(a);
        }
        private void xx_Click(object sender, RoutedEventArgs e)
		{
            double a;
            a = Convert.ToDouble(A.Text);
            result.Content = cl.xx(a);
		}
        private void log_Click(object sender, RoutedEventArgs e)
        {
            double a;
            a = Convert.ToDouble(A.Text);
            result.Content = cl.log(a);
        }
    }
}
