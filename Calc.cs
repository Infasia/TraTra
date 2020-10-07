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
        public int devide(int a, int b)
        {
            return a / b;
        }
    }
}
