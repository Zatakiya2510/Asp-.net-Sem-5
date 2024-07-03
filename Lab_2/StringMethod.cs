using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class StringMethod
    {
        string sampleString = "  Hello, World! Welcome to C# Programming.  ";
        public void ShowStringMethod()
        {
            

            // Length property
            int length = sampleString.Length;
            Console.WriteLine("Length: " + length);

            // Substring method
            string substring = sampleString.Substring(2, 5);
            Console.WriteLine("Substring: " + substring);

            // IndexOf method
            int index = sampleString.IndexOf("World");
            Console.WriteLine("IndexOf 'World': " + index);

            // Replace method
            string replacedString = sampleString.Replace("World", "Universe");
            Console.WriteLine("Replace 'World' with 'Universe': " + replacedString);

            // ToUpper method
            string upperString = sampleString.ToUpper();
            Console.WriteLine("ToUpper: " + upperString);

            // ToLower method
            string lowerString = sampleString.ToLower();
            Console.WriteLine("ToLower: " + lowerString);

            // Trim method
            string trimmedString = sampleString.Trim();
            Console.WriteLine("Trim: '" + trimmedString + "'");

            // Contains method
            bool containsHello = sampleString.Contains("Hello");
            Console.WriteLine("Contains 'Hello': " + containsHello);

            // Split method
            string[] words = sampleString.Split(' ');
            Console.WriteLine("Split by space:");
            foreach (string word in words)
            {
                Console.WriteLine("'" + word + "'");
            }

            // Additional common methods

            // StartsWith method
            bool startsWithHello = sampleString.StartsWith("Hello");
            Console.WriteLine("StartsWith 'Hello': " + startsWithHello);

            // EndsWith method
            bool endsWithProgramming = sampleString.EndsWith("Programming.");
            Console.WriteLine("EndsWith 'Programming.': " + endsWithProgramming);

            // Join method
            string joinedString = string.Join(", ", words);
            Console.WriteLine("Join words with ', ': " + joinedString);

            // Compare method
            int compareResult = string.Compare("cat", "apple");
            Console.WriteLine("Compare 'apple' with 'banana': " + compareResult);

            // IsNullOrEmpty method
            bool isNullOrEmpty = string.IsNullOrEmpty(sampleString);
            Console.WriteLine("IsNullOrEmpty: " + isNullOrEmpty);

            // IsNullOrWhiteSpace method
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(sampleString);
            Console.WriteLine("IsNullOrWhiteSpace: " + isNullOrWhiteSpace);
        }
    }
}
