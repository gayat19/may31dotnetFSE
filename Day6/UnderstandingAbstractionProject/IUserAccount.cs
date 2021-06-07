using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionProject
{
    interface IUserAccount
    {
        void OpenAccount();
        void DoTrasaction(double amount,bool creditStatus);
        void CloseAccount();
    }
}
