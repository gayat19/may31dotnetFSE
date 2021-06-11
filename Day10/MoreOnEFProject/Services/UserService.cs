using MoreOnEFProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnEFProject.Services
{
    public class UserService
    {
        readonly StoreContext _context;
        public UserService()
        {
            _context = new StoreContext();
        }
        public bool UserLogin(User user)
        {
            try
            {
                User myUser = _context.users.Single(u => u.Username == user.Username 
                && u.Password == user.Password);
                if (myUser != null)
                    return true;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Null argument");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
             catch (InvalidOperationException e)
            {
                Console.WriteLine("Could not find the user");//Always use a user friendly message
                Console.WriteLine(e.Message);//It might not be a user undertandable message
                Console.WriteLine(e.StackTrace);//Not for teh user only for teh developer
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops something went worng....");
            }
            finally
            {
                Console.WriteLine("Always");
            }
            return false;
        }
    }
}
