using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Calc
    {

        public int sum (int a, int b)
        {
            return a + b;
        }
        public int minus(int a, int b)
        {
            return a - b;
        }
        public int multy(int a, int b)
        {
            return a * b;
        }
        public double devide(double a, double b)
        {
            return a / b;
        }
        public double sq(double a)
        {
            return Math.Sqrt(a);
        }
        public double kva(double a, double b)
        {
            return Math.Pow(a,b);
        }
        public double sin (double a)
        {
            return Math.Sin(a);
        }
        public double cos (double a)
        {
            return Math.Cos(a);
        }
        public double tan(double a)
        {
            return Math.Tan(a);
        }
        public double cot(double a)
        {
            return 1 / Math.Tan(a);
        }
        public double sec (double a)
        {
            return 1 / Math.Cos(a);
        }
        public double csc (double a)
        {
            return 1 / Math.Sin(a);
        }
        public double ln(double a )
        {
            return Math.Log10(a);
        }
        public double log(double a )
        {
            return Math.Log(a);
        }
        public double xx(double a)
		{
            int x = 10;
            return Math.Pow(x,a);
		}
    }
}
