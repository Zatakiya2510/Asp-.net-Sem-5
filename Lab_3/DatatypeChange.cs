using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class DatatypeChange
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Integer = " + (a + b));
        }

        public void Sum(double a, double b)
        {
            Console.WriteLine("Double = " + (a + b));
        }

    }
}
