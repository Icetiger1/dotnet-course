using Model;

namespace Infrastructure

class ContactPrint
{
    public string ContactToString(Contact contact)
    {
        string output = string.Empty;

        output += $"FirstName: {contac.FirstName}\n"
        output += $"LastName: {contac.LastName}\n"
        output += $"TelephoneNumber: {contac.TelephoneNumber}\n"
        output += $"DayOfBirth: {contac.DayOfBirth}\n"
        output += $"Email: {contac.Email}\n"
    }
}