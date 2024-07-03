using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Fcatorial
    {   

        public void Factorialnum(int a)
        {
     
            int ans = 1;
            for (int j = 1; j <= a; j++)
            {
                ans = ans * j;
            }
            Console.WriteLine(ans); 
        }
    }
}
