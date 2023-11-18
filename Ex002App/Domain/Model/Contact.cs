using System.Xml;
using System;

namespace Model
{
    public class Contact
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set;}
        public string TelephoneNumber{  get; set; }
        public DateOnly DayOfBirth{ get; set; }
        public string Email{get; set; }

        public Contact()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            TelephoneNumber = string.Empty;
            DayOfBirth = new DateOnly();
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
}
