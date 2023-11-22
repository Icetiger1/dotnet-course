using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public static class ContactExtensions
    {
        public static void Print(this Contact user)
        {
            Console.WriteLine("======");
            Console.WriteLine(user.Nickname);
            Console.WriteLine(user.TelephoneNumber);
            Console.WriteLine("======");
        }
    }
}
