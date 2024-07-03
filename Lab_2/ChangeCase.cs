using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class ChangeCase
    {
        public static char ChangeCase1(char input)
        {
            if (char.IsLower(input))
            {
                return char.ToUpper(input);
            }
            else if (char.IsUpper(input))
            {
                return char.ToLower(input);
            }
            else
            {
                throw new ArgumentException("The input must be an alphabetical character.");
            }
        }
    }
}
