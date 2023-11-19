using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure
{
    internal class ContactCreator
    {
        private string[] firstNames;
        private string[] lastNames;
        private string[] mails;

        public ContactCreator(
            string pathToFistNamesFile = "first_names.txt",
            string pathToLastNamesFile = "last_names.txt")
        {
            this.firstNames = File.ReadAllLines(pathToFistNamesFile);
            this.lastNames = File.ReadAllLines(pathToLastNamesFile);
            this.mails = new string[] { "i@mail.ru", "ya@mail.ru", "ooo@ya.ru", "gg@gmail.ru" };
        }

        public Contact GetContact()
        {
            int lenghtFn = firstNames.Length;
            int lenghtLn = lastNames.Length;
            string firstName = this.firstNames[Random.Shared.Next(lenghtFn)];
            string lastName = this.lastNames[Random.Shared.Next(lenghtLn)];
            string mail = this.mails[Random.Shared.Next(mails.Length)];

            Contact contact = new Contact();
            contact.FirstName = firstName;
            contact.LastName = lastName;

            string pattern = "+7 ({0}) {1}-{2}-{3}";
            contact.TelephoneNumber = string.Format(
                pattern,
                Random.Shared.Next(900, 1000),
                Random.Shared.Next(100, 1000),
                Random.Shared.Next(10, 100),
                Random.Shared.Next(10, 100)
            );
            
            contact.Email = mail;

            return contact;
        }
    }
}
