using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Staff
    {
        String Name, Department, Designation;
        int Experience;
        double Salary;
        public void getStaffDeatils()
        {
            Console.WriteLine("Enter Name ");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Department");
            this.Department = Console.ReadLine();
            Console.WriteLine("Enter Designation");
            this.Designation = Console.ReadLine();
            Console.WriteLine("Enter Experience");
            this.Experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            this.Salary = double.Parse(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            if (this.Designation == "HOD" || this.Designation == "hod")
            {
                Console.WriteLine("Name = " + this.Name);
                Console.WriteLine("Salary = " + this.Salary);
            }
        }
    }
}
