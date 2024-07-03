using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class EvenNumberException
    {
        public class OddNumberException:Exception
        {
            public OddNumberException(string message) : base(message)
            {
            }
        }
        public static class NumberChecker
        {
            public static void CheckEvenNumber(int number)
            {
                if (number % 2 != 0)
                {
                    throw new OddNumberException("The number is not even.");
                }
            }
        }
    }
}
