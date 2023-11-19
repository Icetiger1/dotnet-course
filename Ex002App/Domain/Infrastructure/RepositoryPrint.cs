using Persistence;
using Model;

namespace Infrastructure
{
    public class RepositoryPrint
    {
        public string Print(ContactRepository repository)
        {
            ContactPrint pc = new ContactPrint();
            string output = string.Empty;

            var contacts = repository.GetAll();

            foreach(Contact contact1 in contacts)
            {
                output += $"{pc.ContactToString(contact1)}\n";
            }

            return output;
        }
    }
}