using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Console.Shared.Models;

namespace UserManagement.Console.Application.Services
{
    public class UserService
    {
        static int userID = 0;

        private static List<User> Users = new List<User>() 
        {
           new User(1, "Abu", "Bulbulia","abu@gmail.com","Developer", "1999/25/04", "0838929770"),
        };

        public static IEnumerable<User> GetUsers() { return Users; }

        public static void AddUser(User user)
        {
            userID++;
            user.PersonId = userID;
            Users.Add(user);
        }

        public static void RemoveUser(int userID) 
        {
            User userToDelete = Users.Find(user => user.PersonId == userID);
            Users.Remove(userToDelete);
        }

        public static string DisplayUsers()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var user in Users)
            {
                stringBuilder.AppendLine($"Name: {user.FirstName} {user.LastName}, Email: {user.EmailAddress}, Role: {user.JobRole}");
            }

            return stringBuilder.ToString();
        }

        //public static bool UpdateUserInformation(User updatedUser)
        //{
        //    User user = Users.Find(u => u.PersonId == (updatedUser.PersonId));

        //    if (user != null)
        //    {

        //      user.FirstName = updatedUser.FirstName;
        //      user.LastName = updatedUser.LastName;
        //      user.EmailAddress = updatedUser.EmailAddress;
        //      user.DateOfBirth = updatedUser.DateOfBirth;
        //      user.PhoneNumber = updatedUser.PhoneNumber;
        //      user.JobRole = updatedUser.JobRole;


        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public static User FindUserByID(int userID) 
        {
           var user = Users.FirstOrDefault(u => u.PersonId == userID);

            return user;
        }
        public static string UserSearch(User user) 
        {
            User userToFind = Users.Find(u => u.FirstName == user.FirstName && u.EmailAddress == user.EmailAddress);

            StringBuilder stringBuilder = new StringBuilder();

            if (userToFind != null)
            {
                stringBuilder.AppendLine($"The user's information is:");
                stringBuilder.AppendLine($"First Name: {userToFind.FirstName}");
                stringBuilder.AppendLine($"Last Name: {userToFind.LastName}");
                stringBuilder.AppendLine($"Email Address: {userToFind.EmailAddress}");
                stringBuilder.AppendLine($"Job Role: {userToFind.JobRole}");
                stringBuilder.AppendLine($"Date Of Birth: {userToFind.DateOfBirth}");
                stringBuilder.AppendLine($"Phone Number: {userToFind.PhoneNumber}");

                return stringBuilder.ToString();

            }
            else
            {
                return stringBuilder.AppendLine("The user could not be found.").ToString();
            }
        }

    }
}
