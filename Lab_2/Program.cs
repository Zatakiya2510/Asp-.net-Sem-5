// See https://aka.ms/new-console-template for more information
using static Lab_2.EvenNumberException;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("===Enter 0 to Console App STOP===");
                Console.WriteLine("1.DividedByZeroException\n2.ArrayIndexOfBoundException \n3.AbstractClass\n4.InterFace Example\n5.String Method Use \n6.Case Swaping \n7.Shape Area Calculate \n8.Even Number exception \n9.String Longest Word Find \n10.Case Change");
                Console.WriteLine("========================================================");
                int choice;
                choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        RunDevidedByZero();
                        break;
                    case 2:
                        RunArrayOutOfBound();
                        break;
                    case 3:
                        RunAbstarctClass();
                        break;
                    case 4:
                        RunInterFace();
                        break;
                    case 5:
                        RunStringMethod();
                        break;
                    case 6:
                        RunCaseSwap();
                        break;
                    case 7:
                        RunShapeArea();
                        break;
                    case 8:
                        RunEvenOddException();
                        break;
                    case 9:
                        RunStringLongestWord();
                        break;
                    case 10:
                        RunCaseChanging();
                        break;
                    case 0:
                        break;

                }

            }
           
        }

        static void RunDevidedByZero()
        {
            DivideByZeroExp d1 = new DivideByZeroExp();
            d1.TryCatch();

        }
        static void RunArrayOutOfBound()
        {
            ArrayBoundExp e1= new ArrayBoundExp();
            e1.ArrayBound();
        }
        static void RunAbstarctClass()
        {
            Calculate a1 = new Calculate();
            int result1 = a1.SumOfTwo(3, 5);
            Console.WriteLine("Sum of 3 and 5 is: " + result1);

            int result2 = a1.SumOfThree(3, 5, 7);
            Console.WriteLine("Sum of 3, 5 and 7 is: " + result2);
        }

        static void RunInterFace()
        {
           Result  result = new Result();

            
            int addResult = result.Addition(10, 5);
            Console.WriteLine("Addition of 10 and 5 is: " + addResult);

          
            int subResult = result.Subtraction(10, 5);
            Console.WriteLine("Subtraction of 10 and 5 is: " + subResult);
        }
        static void RunStringMethod()
        {
            StringMethod s1= new StringMethod();
            s1.ShowStringMethod();
        }

        static void RunCaseSwap()
        {
            CaseSwaping c1=new CaseSwaping();
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

           
            string result = c1.SwapCase(input);

            
            Console.WriteLine("Modified string: " + result);
        }

        static void RunShapeArea()
        {
            AreaCalculate a1 = new AreaCalculate();
            double circleArea = a1.Circle(5);
            Console.WriteLine("Area of circle with radius 5: " + circleArea);

          
            double triangleArea = a1.Triangle(5, 10);
            Console.WriteLine("Area of triangle with base 5 and height 10: " + triangleArea);

           
            double squareArea = a1.Square(5);
            Console.WriteLine("Area of square with side length 5: " + squareArea);

        }
        static void RunEvenOddException()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                
                NumberChecker.CheckEvenNumber(number);

                Console.WriteLine("The number is even.");
            }
            catch (OddNumberException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
        static void RunStringLongestWord()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string longestWord = StringLongestWord.FindLongestWord(input);

            if (!string.IsNullOrEmpty(longestWord))
            {
                Console.WriteLine($"The longest word is: {longestWord}");
            }
            else
            {
                Console.WriteLine("No words found in the input string.");
            }
        }
        static void RunCaseChanging()
        {
            try
            {
                Console.Write("Enter a single alphabetical character: ");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine(); 

                char changedCaseCharacter = ChangeCase.ChangeCase1(input);
                Console.WriteLine($"The changed case character is: {changedCaseCharacter}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
