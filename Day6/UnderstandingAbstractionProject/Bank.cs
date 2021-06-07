using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionProject
{
    class Bank
    {
        public Bank()
        {
            Manager manager = new Manager();
            Account account = new Account();
            CustomerInteraction(manager,account);
            CustomerInteraction(account,manager);
            UseManagerLunchTime(manager);
            EmployeeInteteraction(manager);
            
        }
        void CustomerInteraction(ICustomerManager customerManager)
        {
            Console.WriteLine("Customer Interaction Time");
            customerManager.ApproveCustomerLoan();
            customerManager.SolveCustomerIssues();
        }
        void CustomerInteraction(ICustomerManager customerManager,IBankAccount account)
        {
            Console.WriteLine("Customer Interaction Time");
            customerManager.ApproveCustomerLoan();
            customerManager.SolveCustomerIssues();
            Console.WriteLine("Account Closure");
            account.BarAccount();
            Console.WriteLine(account);
        }
        void CustomerInteraction( IUserAccount account, ICustomerManager customerManager)
        {
            Console.WriteLine("New Customer");
            account.OpenAccount();
            Console.WriteLine(account);

            customerManager.ApproveCustomerLoan();
            account.DoTrasaction(100000, true);
            Console.WriteLine(account);
        }
        void EmployeeInteteraction(IEmployeeManager employeeManager)
        {
            Console.WriteLine("Employee Manager time");
            employeeManager.ConductAppraisals();
            employeeManager.ConductStaffMeeting();
        }
        void UseManagerLunchTime(IHumanManager humanManager)
        {
            Console.WriteLine("Manager Lunch time");
            humanManager.Eat();
            humanManager.Sleep();
        }
        static void Main(string[] a)
        {
            new Bank();
            Console.ReadKey();
        }
    }
}
