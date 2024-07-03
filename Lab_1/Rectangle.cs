using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Rectangle
    {
        int x, y;
        int area;
        public void getDetails()
        {
            Console.Write("Enetr length of rectangle : ");
            x= int.Parse(Console.ReadLine());
            Console.Write("Enter breathe of rectangle :");
            y= int.Parse(Console.ReadLine());
        }
        public void getReactangelArea()
        {
            area = x * y;
            Console.WriteLine("Area of rectangel is : " + area);
        }
    }
}
