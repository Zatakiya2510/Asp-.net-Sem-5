using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Distance
    {
        double dist1, dist2, dist3; 
        public Distance() {
            Console.WriteLine("Enter Dist1");
            this.dist1 = Convert.ToDouble(Console.ReadLine);
            Console.WriteLine("Enter Dist2");
            this.dist2 = Convert.ToDouble(Console.ReadLine); 
        }
        public void Sum()
        {
            this.dist3 = this.dist1 + this.dist2;
        }
        public void Display()
        {
            Console.WriteLine("Answer = " + this.dist3);
        }
    }
}
