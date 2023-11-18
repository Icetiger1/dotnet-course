using Infrastructure;
using Persistence;

namespace ContactApplication
{
    public class Startup
    {

        public static void Run()
        {
            RepositoryPrint repositoryPrint = new();
            ContactCreator contactCreator = new();
            ContactRepository repo = new();

            for (int i = 0; i < 10; i++)
            {
                repo.Append(contactCreator.GetContact());
            }

            string res = repositoryPrint.Print(repo);
            Console.WriteLine(res);

        }

    }
}
