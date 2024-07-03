using Lab_4;
using System.Drawing;

namespace Lab_4
{
    public class Lab_4
    {
        public static void Main(String[] args)
        {
            bool flag = true;
            Console.WriteLine("Enter one choices");
            Console.WriteLine("1 for student in arraylist");
            Console.WriteLine("2 for student in list");
            Console.WriteLine("3 for student in stack");
            Console.WriteLine("4 for student in queue");
            while (flag)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {


                    case 1:
                        StudentArray studentArray = new StudentArray();
                        studentArray.arrMethod();
                        break;
                    case 2:
                        StudentList studentList = new StudentList();
                        studentList.ListMethod();
                        break ;
                    case 3:
                        StackDemo stackDemo = new StackDemo();
                        stackDemo.StackMethod("Abhishek");
                        break ;
                    case 4:
                        QueueDemo queueDemo = new QueueDemo();
                        queueDemo.QueueMethod();
                        break ;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}