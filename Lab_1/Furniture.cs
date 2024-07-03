using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Furniture
    {
        public string material;
        public double price;

        public void getDetails()
        {
            Console.WriteLine("Enter the material");
            material = Console.ReadLine();

            Console.WriteLine("Enter the price");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public void displayDetails()
        {
            Console.WriteLine(material);
            Console.WriteLine(price);
        }
        public class Table : Furniture
        {

            public double height;
            public double surface_area;

            public void getDetails()
            {
                base.getDetails();
                Console.WriteLine("Enter the height of table");
                height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the height of surface area");
                surface_area = Convert.ToDouble(Console.ReadLine());

            }

            public void displayDetails()
            {
                base.displayDetails();
                Console.WriteLine(height);
                Console.WriteLine(surface_area);
            }
        }
    }
}