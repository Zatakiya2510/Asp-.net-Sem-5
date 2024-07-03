using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Areas
    {
        public void Area(int side)
        {
            Console.WriteLine("Area of Square = " + (side * side));
        }

        public void Area(int side,int broad)
        {
            Console.WriteLine("Area of Rectangle = " + (side * broad));
        }
        public void Area(double radius)
        {
            double ans = 3.14*radius*radius;
            Console.WriteLine("Area of Circule = " + ans);
        }
    }

}
