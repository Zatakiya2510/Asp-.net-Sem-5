namespace Lab_1
{
    public class Lab_1
    {
        public static void Main(String[] args)
        {
            bool flag = true;
            Console.WriteLine("Enter one choices");
            Console.WriteLine("1 for Candidate");
            Console.WriteLine("2 for Staff");
            Console.WriteLine("3 for Bank");
            Console.WriteLine("4 for Student");
            Console.WriteLine("5 for Reactangel area");
            Console.WriteLine("6 for Interst");
            Console.WriteLine("7 for salary");
            Console.WriteLine("8 for distance");
            while (flag)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Candidate cd = new Candidate();
                        cd.GetCandidateDetails();
                        cd.DiplayCandidateDetails();
                        break;
                    case 2:
                        Staff[] staff = new Staff[5];
                        for (int i = 0; i < staff.Length; i++)
                        {
                            staff[i] = new Staff();
                            staff[i].getStaffDeatils();
                        }
                        for (int i = 0; i < staff.Length; i++)
                        {

                            staff[i].DisplayDetails();
                        }
                        break;
                    case 3:
                        Bank b = new Bank();
                        b.getDetails();
                        b.displayDetails();
                        break;
                    case 4:
                        Student st = new Student();
                        st.displayStudentsDetails();
                        break;
                    case 5:
                        Rectangle r = new Rectangle();
                        r.getDetails();
                        r.getReactangelArea();
                        break;
                    case 6:
                        Account_Details account = new Account_Details();
                        Interest interest = new Interest();
                        interest.GetAccountDetails();
                        interest.DisplayInterest();
                        break;
                    case 7:
                        Salary sal = new Salary();
                        sal.Display();
                        break;
                    case 8:
                        Distance distance = new Distance();
                        distance.Sum();
                        distance.Display();
                        break;
                    case 9:
                        Furniture f = new Furniture();
                        f.getDetails();
                        f.displayDetails();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}