using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserContact : Contact, IComparable<UserContact>, IEquatable<UserContact>
    {
        public UserContact() :
        this(String.Empty,
             String.Empty,
             String.Empty,
             DateOnly.MinValue,
             "nil")
        {
        }

        public UserContact(
          string firstName,
          string lastName,
          string telephoneNumber,
          DateOnly dayOfBirth,
          string email) : base(telephoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DayOfBirth = dayOfBirth;
            this.Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DayOfBirth { get; set; }
        public string Email { get; set; }

        public override string Nickname
        {
            get
            {
                return $"[{this.FirstName} {this.LastName}]";
            }
        }

        public int CompareTo(UserContact? other)
        {
            return this.LastName.CompareTo(other.LastName);
        }

        public bool Equals(UserContact? other)
        {
            return this.FirstName == other.FirstName
            && this.LastName == other.LastName
            && this.TelephoneNumber == other.TelephoneNumber;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string output = String.Empty;

            output += $"FirstName: {this.FirstName}\n";
            output += $"LastName: {this.LastName}\n";
            output += base.ToString();
            output += $"DayOfBirth: {this.DayOfBirth}\n";
            output += $"Email: {this.Email}\n";

            return output;
        }
    }
}
