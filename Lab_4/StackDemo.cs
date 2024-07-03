using System;
using System.Collections;

namespace Lab_4
{
    public class StackDemo
    {
        Stack s = new Stack();

        public void StackMethod(string item)
        {
            s.Push("Abhishek");
            s.Push("Bhargav");
            s.Push("Jay");
            s.Push("Abhi");

            Console.WriteLine("Stack after pushes:");
            foreach (var element in s)
            {
                Console.WriteLine(element);
            }

            s.Pop();

            Console.WriteLine("Stack after pop:");
            foreach (var element in s)
            {
                Console.WriteLine(element);
            }

            var topElement = s.Peek();
            Console.WriteLine($"Top element is: {topElement}");

            bool containsItem = s.Contains(item);
            Console.WriteLine($"Stack contains '{item}': {containsItem}");

            s.Clear();
            Console.WriteLine("Stack cleared.");

            Console.WriteLine("Stack after clearing:");
            foreach (var element in s)
            {
                Console.WriteLine(element);
            }
        }
    }
}
