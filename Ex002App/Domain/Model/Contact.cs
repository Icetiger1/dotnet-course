using System.Xml;
using System;
using System.Data.SqlTypes;

namespace Model
{
    public class Contact
    {

        public Contact()
        {
            this.TelephoneNumber = string.Empty;
        }

        public Contact(string telephoneNumber)
        {
            this.TelephoneNumber = telephoneNumber;
        }
        
        public int Id { get; set; }
        public virtual string Nickname { get; }
        public string TelephoneNumber { get; set; }

        public override string ToString()
        {
            string output = String.Empty;
            output += $"Id: {this.Id}\n";
            output += $"TelephoneNumber: {this.TelephoneNumber}\n";
            return output ;
        }
    }
}
