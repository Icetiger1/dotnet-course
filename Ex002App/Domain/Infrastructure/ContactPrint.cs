using Model;

namespace Infrastructure
{
    class ContactPrint
    {
        public string ContactToString(Contact contact)
        {
            string output = string.Empty;

            output += $"FirstName: {contact.FirstName}\n";
            output += $"LastName: {contact.LastName}\n";
            output += $"TelephoneNumber: {contact.TelephoneNumber}\n";
            output += $"DayOfBirth: {contact.DayOfBirth}\n";
            output += $"Email: {contact.Email}\n";
            
            return output;
        }
    }
}