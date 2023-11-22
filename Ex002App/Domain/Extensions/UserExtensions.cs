using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public static class UserExtensions
    {
        public static void Print(this User user)
        {
            Console.WriteLine("====");
            Console.WriteLine(user.Login);
            Console.WriteLine(user.Password);
            Console.WriteLine("====");
        }
    }
}
