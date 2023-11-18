using System.Text.RegularExpressions;
using Infrastructure;
using Model;
using Persistance;

class Program
{
    static void Main(string[] args)
    {
        Contact contact1 = new(
            "Sergei", 
            "Kamianetskii", 
            "89101234567", 
            new DateOnly(1990,9,28), 
            "i@ksergey.ru"
            );

        Contact contact2 = new(
            "Viktor", 
            "Kamianetskii", 
            "89101234567", 
            new DateOnly(1990,9,28), 
            "i@kvictor.ru"
            );

        ContactPrint printer = new ContactPrint();
        string output = printer.ContactToString(contact1);
        Console.WriteLine(output);
        output = printer.ContactToString(contact2);
        Console.WriteLine(output);

        ContactRepository repo = new()
        {
            repo.Append(contact1);
            repo.Append(contact2);
        }

        RepositoryPrint repos = new();
        string res = repos.Print(repo);
        Console.WriteLine(res);
    }
}
