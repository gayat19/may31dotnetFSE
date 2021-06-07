using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionProject
{
    class Manager : ICustomerManager,IEmployeeManager,IHumanManager
    {
      
        public void ConductStaffMeeting()
        {
            Console.WriteLine("Conducts meeting");
        }
        public void ConductAppraisals()
        {
            Console.WriteLine("Conducts Employee appraisals");
        }
        public void ApproveCustomerLoan()
        {
            Console.WriteLine("Loan approved");
        }
        public void SolveCustomerIssues()
        {
            Console.WriteLine("Listens and solves issues");
        }
        public void Eat()
        {
            Console.WriteLine("Eat food");
        }
        public void Sleep()
        {
            Console.WriteLine("seven * snoozeeeeeeeeee");
        }
    }
}
