using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class DivideByZeroExp
    {
        int num1 = 10;
        int num2 = 0;

        public void TryCatch()
        {
            try
            {
                int result = DivideNumbers(num1, num2);
                Console.WriteLine("The result of the division is: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message + ". Division by zero is not allowed.");
            }


            static int DivideNumbers(int num1, int num2)
            {
                // This will throw a DivideByZeroException if denominator is zero
                return num1 / num2;
            }
        }

    }
}
