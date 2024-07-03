using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class StudentList
    {
        List<string> s = new List<string>();

        public void ListMethod()
        {
            s.Add("Abhishek");
            s.Add("Bhargav");
            s.Add("Jay");
            s.Add("Abhi");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            s.Remove("Abhishek");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            s.RemoveRange(1, 2);

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            s.Clear();



        }
    }
}
