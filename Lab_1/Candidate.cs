using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Candidate
    {
        int Id, Age;
        String Name;
        double Weight, Height;
        public void GetCandidateDetails()
        {
            Console.Write("Enter Id : ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Weight : ");
            Weight = double.Parse(Console.ReadLine());
            Console.Write("Enter Height : "); 
            Height = double.Parse(Console.ReadLine());
        }
        public void DiplayCandidateDetails()
        {
            Console.WriteLine("ID : " + this.Id);
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("Age : " + this.Age);
            Console.WriteLine("Weight : " + this.Weight);
            Console.WriteLine("Height : " + this.Height);
        }
    }
}
