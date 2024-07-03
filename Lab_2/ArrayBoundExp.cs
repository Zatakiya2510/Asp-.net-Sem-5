using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class ArrayBoundExp
    {
        int[] Number = new int[5];
        public void ArrayBound()
        {
            Console.WriteLine("Please enter 5 numbers:");
            for (int i = 0; i < Number.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                Number[i] = int.Parse(Console.ReadLine());
            }
            try
            {
                Console.WriteLine("Attempting to access an index outside the bounds of the array...");
               
                int invalidIndex = 10;
                int invalidNumber = Number[invalidIndex];
                Console.WriteLine($"Number at index {invalidIndex}: {invalidNumber}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message + ". Attempted to access an index that is out of bounds.");
            }

        }

    }
}
