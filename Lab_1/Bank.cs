using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Bank
    {
        double Account_No, Account_Balance;
        String Email, User_Name, Account_Type;
        public void getDetails()
        {
            Console.WriteLine("Enter Account no ");
            this.Account_No = Convert.ToDouble(Console.ReadLine);
            Console.WriteLine("Enter Account Balance ");
            this.Account_Balance = Convert.ToDouble(Console.ReadLine);
            Console.WriteLine("Enter Email");
            this.Email = Console.ReadLine();
            Console.WriteLine("Enter User_Name");
            this.User_Name = Console.ReadLine();
            Console.WriteLine("Enter Account_Type");
            this.Account_Type = Console.ReadLine();
        }

        public void displayDetails()
        {
            Console.WriteLine("Account number : {0}", this.Account_No);
            Console.WriteLine("Email : {0}", this.Email);
            Console.WriteLine("Username : {0}", this.User_Name);
            Console.WriteLine("Account type : {0}", this.Account_Type);
            Console.WriteLine("Account balance : {0}", this.Account_Balance);
        }
    }
}
