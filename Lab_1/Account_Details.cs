using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Account_Details
    {
        public string AccountHolderName;
        public double AccountBalance;
        public double InterestRate;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter Account Holder's Name: ");
            AccountHolderName = Console.ReadLine();

            Console.WriteLine("Enter Account Balance: ");
            AccountBalance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Interest Rate (in percentage): ");
            InterestRate = Convert.ToDouble(Console.ReadLine());
        }
    }


    public class Interest : Account_Details
    {
        public double CalculateInterest()
        {
            return AccountBalance * (InterestRate / 100);
        }


        public void DisplayInterest()
        {
            double interest = CalculateInterest();
            Console.WriteLine("Total Interest: " + interest);
        }
    }

}
