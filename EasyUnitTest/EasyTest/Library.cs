using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTest
{
    public class Library
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public double Sqrl (double a)
        {
            return Math.Sqrt(a);
        }
        public int Pow (int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
}
