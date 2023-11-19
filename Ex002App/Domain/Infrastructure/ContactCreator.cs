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

        public ContactCreator(
            string pathToFistNamesFile = "first_names.txt",
            string pathToLastNamesFile = "last_names.txt")
        {
            this.firstNames = File.ReadAllLines(pathToFistNamesFile);
            this.lastNames = File.ReadAllLines(pathToLastNamesFile);
        }

        public Contact GetContact()
        {
            int lenghtFn = firstNames.Length;
            int lenghtLn = lastNames.Length;
            string firstName = this.firstNames[Random.Shared.Next(lenghtFn)];
            string lastName = this.lastNames[Random.Shared.Next(lenghtLn)];

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

            return contact;
        }
    }
}
