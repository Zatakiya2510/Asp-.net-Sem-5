using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class StudentArray
    {
        ArrayList a = new ArrayList();

       public void arrMethod()
        {
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            a.Remove(2);
            foreach (var item in a)
            {
                Console.WriteLine( item);
            }
            a.RemoveRange(1,2);
            
            foreach (var item in a)
            {
                Console.WriteLine( item);
            }
            a.Clear();
            

            
        }

    }
}
