using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Area
    {
        public void area(int a)
        {
            Console.WriteLine("Square = " + (a * a));

        }
        public void area(int a, int b)
        {
            Console.WriteLine("Rectangle= " + (a * b));

        }
    }
}
