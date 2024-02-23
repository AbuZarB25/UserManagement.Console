using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Console.Shared.Models
{
    public class User
    {
        public User(int personId, string firstName, string lastName, string emailAddress, string jobRole, string dateOfBirth, string phoneNumber)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            JobRole = jobRole;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }

        public User()
        {

        }

        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string JobRole { get; set; }

        public string DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

  
    }
}
