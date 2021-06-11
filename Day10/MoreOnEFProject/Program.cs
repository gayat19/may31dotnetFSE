using MoreOnEFProject.Models;
using MoreOnEFProject.Services;
using System;

namespace MoreOnEFProject
{
    class Program
    {
        UserService userService;
        public Program()
        {
            userService = new UserService();
        }
        void UserCheck()
        {
            User myUser =  TakeUserDetails();
            if (userService.UserLogin(myUser))
                Console.WriteLine("Welcome");
            else
                Console.WriteLine("Invalid username or password");
        }

        private User TakeUserDetails()
        {
            User user = new User();
            Console.WriteLine("Please enter your username");
            user.Username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            user.Password = Console.ReadLine();
            return user;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.UserCheck();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
