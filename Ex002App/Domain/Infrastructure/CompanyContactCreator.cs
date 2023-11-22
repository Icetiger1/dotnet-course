using Domain.Model;
using Infrastructure;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure
{
    public class CompanyContactCreator : IContactCreator
    {
        private readonly Repository<UserContact> userRepo;
        private string[] companyNames;

        public CompanyContactCreator(Repository<UserContact> userRepo)
        {
            this.companyNames = new string[100];

            for (int i = 0; i < companyNames.Length; i++)
            {
                this.companyNames[i] = $"Компания {Guid.NewGuid().ToString().Substring(0, 5)}";
            }

            this.userRepo = userRepo;
        }

        public Contact GetContact()
        {
            int lenght = this.companyNames.Length;
            string name = this.companyNames[Random.Shared.Next(lenght)];

            CompanyContact contact = new();
            contact.Name = name;

            string pattern = "+7 {0} {1}-{2}-{3}";
            contact.TelephoneNumber = string.Format(
                pattern,
                Random.Shared.Next(100, 1000),
                Random.Shared.Next(100, 1000),
                Random.Shared.Next(10, 100),
                Random.Shared.Next(10, 100)
            );

            contact.Fax = String.Format("+7 (911) {0}-{1}-{2}-{3}",
                Random.Shared.Next(10, 100),
                Random.Shared.Next(10, 100),
                Random.Shared.Next(10, 100),
                Random.Shared.Next(10, 100));

            contact.OGRN = $"{Random.Shared.Next(1000, 10000)}";

            UserContact[] userContacts = userRepo.GetAll();

            contact.ManagerId = userContacts[Random.Shared.Next(userContacts.Length)].Id; 

            return contact;
        }
    }
}
