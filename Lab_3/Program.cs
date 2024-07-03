using Lab_3;
using System.Drawing;

namespace Lab_3
{
    public class Lab_3
    {
        public static void Main(String[] args)
        {
            bool flag = true;
            
            while (flag)
            {
                Console.WriteLine("Enter one choices");
                Console.WriteLine("1 for Addition");
                Console.WriteLine("2 for Area of square and rectangle");
                Console.WriteLine("3 for Intrest");
                Console.WriteLine("4 for Factorial");
                Console.WriteLine("5 for Hospital");
                Console.WriteLine("6 for Area of square , rectangle and circle");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        DatatypeChange datatypeChange = new DatatypeChange();
                        datatypeChange.Sum(2,5);
                        datatypeChange.Sum(2.5,5.5);
                        break;
                    case 2:
                        Area area = new Area();
                        area.area(2);
                        area.area(2, 3);
                        break;
                    case 3:
                        HDFC hDFC = new HDFC();
                        hDFC.calculateInterest(2, 1000, 5);
                        SBI sbi = new SBI();
                        sbi.calculateInterest(2, 1000, 5);
                        ICICI icici = new ICICI();
                        icici.calculateInterest(2, 1000, 5);
                        break;
                    case 4:
                        Fcatorial fcatorial = new Fcatorial();
                        fcatorial.Factorialnum(10);
                        break;
                    case 5:
                        Apollo apollo = new Apollo();
                        apollo.HospitalDetails("Apollo" ,250);
                        Wockhardt wockhardt = new Wockhardt();
                        wockhardt.HospitalDetails("Wockhardt", 250);
                        GokulSuperspeciality gokulSuperspeciality = new GokulSuperspeciality();
                        gokulSuperspeciality.HospitalDetails("Gokul", 250);
                        break;
                    case 6:
                        Areas areas = new Areas();
                        areas.Area(2);
                        areas.Area(3,3);
                        areas.Area(4);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}