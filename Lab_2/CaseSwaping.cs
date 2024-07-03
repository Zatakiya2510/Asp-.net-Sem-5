using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class CaseSwaping
    {
        public string SwapCase(string input)
        {
            char[] charArray = input.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLower(charArray[i]))
                {
                    
                    charArray[i] = char.ToUpper(charArray[i]);
                }
                else if (char.IsUpper(charArray[i]))
                {
               
                    charArray[i] = char.ToLower(charArray[i]);
                }
            }

          
            return new string(charArray);
        }
    }
}