using Domain.Infrastructure;
using Domain.Model;
using Infrastructure;
using Model;
using Persistence;

namespace ContactApplication
{
    public class Startup
    {
        public static void Run()
        {
            //200.Create("first_names.txt", "���");
            //200.Create("last_names.txt", "���");

            UserContactCreator contactCreator = new();
            Repository<UserContact> userRepository = new();
            CompanyContactCreator companyContactCreator = new(userRepository);
            Repository<CompanyContact> companyRepository = new();

            for (int i = 0; i < 5; i++)
            {
                userRepository.Append((UserContact)contactCreator.GetContact());
                companyRepository.Append((CompanyContact)companyContactCreator.GetContact());
            }

            foreach (UserContact userContact in userRepository.GetAll())
            {
                Console.WriteLine(userContact.Nickname);
            }
            foreach (CompanyContact companyContact in companyRepository.GetAll())
            {
                Console.WriteLine(companyContact.Nickname + " " + companyContact.ManagerId);
            }

            Console.WriteLine();

            foreach (CompanyContact companyContact in companyRepository.GetAll())
            {
                Console.WriteLine($"{companyContact.Name}: ���.: {userRepository.Get(companyContact.ManagerId)?.FirstName}");
            }
            Console.ReadKey();

        }

    }
}
