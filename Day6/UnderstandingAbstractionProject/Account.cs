using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionProject
{
    class Account : IBankAccount, IUserAccount
    {
        public double Balance { get; set; }
        public string AccountStatus { get; set; }
        public Account()
        {
            Balance = 5000;
            AccountStatus = "Yet to be opened";
        }
        public void ApplyFine()
        {
           if(Balance<5000)
                Console.WriteLine("The fine is 250");
           else
                Console.WriteLine("No fine as of now");
        }

        public void BarAccount()
        {
            AccountStatus = "Barred";
            Console.WriteLine("****Your account is bared*****");
        }

        public void CloseAccount()
        {
            AccountStatus = "Closed";
            Console.WriteLine("Account closed");
        }

        public void DoTrasaction(double amount, bool creditStatus)
        {
            if (creditStatus)
                Balance = Balance + amount;
            else
                Balance = Balance - amount;
        }

        public void OpenAccount()
        {
            AccountStatus = "Opened";
            Console.WriteLine("Your account is opened. Congrats!!!");
        }

        public void RetriveCardAmount()
        {
            Balance = Balance - 125.25;
            Console.WriteLine("Card amount debited from balance");
        }

        public override string ToString()
        {
            return "Balance is " + Balance +
                "\nAccount status " + AccountStatus;
        }
    }
}
