using System.Xml;
using System;
namespace Model

    public class Contact
    {
        public string FirstName;
        public string LastName;
        public string TelephoneNumber;
        public DateOnly DayOfBirth;;
        public string Email;

        public Contact()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            TelephoneNumber = string.Empty;
            DayOfBirth = string.Empty;
            Email = string.Empty;
        }

        public Contact(string FirstName, string LastName, string TelephoneNumber, DateOnly DayOfBirth, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.TelephoneNumber = TelephoneNumber;
            this.DayOfBirth = DayOfBirth;
            this.Email = Email;
        }
        
    }
