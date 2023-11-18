namespace Infrastructure;

public class RepositoryPrint
{
    public string Print(ContactRepository repository)
    {
        ContactPrint pc = new ContactPrint();
        string output string.Empty;

        var contacts = repository.GetAll();

        foreach(Contacts contacts1 in contacts)
        {
            output += $"{pc.Print(contacts1)}\n";
        }
    }
}