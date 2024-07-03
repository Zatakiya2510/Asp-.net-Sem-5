using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Student
    {

        double Enrollment_No, CPI, SPI;
        String Student_Name;
        int Semester;
        public Student()
        {
            Console.WriteLine("Please enter Enrollment Number : ");
            this.Enrollment_No = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Student's Name : ");
            this.Student_Name = Console.ReadLine();
            Console.WriteLine("Please enter Sem : ");
            this.Semester = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter CPI : ");
            this.CPI = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter SPI : ");
            this.SPI = double.Parse(Console.ReadLine());
        }
        public void displayStudentsDetails()
        {
            Console.WriteLine("\n ----- Student Details ----- \n");
            Console.WriteLine("Enrollment Number : {0}", this.Enrollment_No);
            Console.WriteLine("Student's Name : {0}", this.Student_Name);
            Console.WriteLine("Sem : {0}", this.Semester);
            Console.WriteLine("CPI : {0}", this.CPI);
            Console.WriteLine("SPI : {0}", this.SPI);
        }
    }

}
