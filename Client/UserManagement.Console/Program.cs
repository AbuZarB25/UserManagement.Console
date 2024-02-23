using UserManagement.Console.Shared.Models;
using UserManagement.Console.Application.Services;
;
string menuSelection = " ";
string? readResult;

do
{
    var allMenuItems = MenuItemService.GetMenuItems();
    foreach (var menuItem in allMenuItems) 
    {
       Console.WriteLine($"{menuItem.MenuItemId} {menuItem.MenuItemDescription}");

    }

    menuSelection = Console.ReadLine();
    //Console.WriteLine($"You selected {menuSelection}");

    switch(menuSelection)
    {
        case "1":
            //Can be refactored 
            User user = new User();
            Console.WriteLine("Enter Your First Name:");
            user.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name:");
            user.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Date Of Birth (YYYY/MM/DD):");
            user.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter Your Email Address:");
            user.EmailAddress = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number:");
            user.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Job Role:");
            user.JobRole = Console.ReadLine();
            Console.WriteLine("User has been added");
            UserService.AddUser(user);
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            Console.WriteLine("These are the available job roles.");
            var allJobRoles = JobRoleService.GetJobRoles();
            foreach (JobRole role in allJobRoles) 
            {
                Console.WriteLine($"{role.JobRoleId} {role.JobRoleName}.");
            }

            Console.WriteLine("Enter Your User ID");
            int userID = int.Parse( Console.ReadLine() );
            Console.WriteLine("Enter the Id of the job role that you would like to add.");
            int roleID = int.Parse( Console.ReadLine() );
            if (roleID > 0 && roleID < 5)
            {
                JobRoleService.ChangeJobRole(userID, roleID);
            }
            else
            {
                Console.WriteLine("The ID you entered was not valid.");
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "3":
            string userDetails = UserService.DisplayUsers();
            Console.WriteLine(userDetails);
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            User userToSearch = new User();
            Console.WriteLine("Enter the name of the user that you would like to find.");
            userToSearch.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the email address of the user that you would like to find.");
            userToSearch.EmailAddress = Console.ReadLine();
            string userFound = UserService.UserSearch(userToSearch);
            Console.WriteLine(userFound);
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            User updatedUser = new User();
            Console.WriteLine("Enter Your Updated First Name:");
            updatedUser.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Your Updated Last Name:");
            updatedUser.LastName = Console.ReadLine();
            Console.WriteLine("Enter Your Updated Date Of Birth (YYYY/MM/DD):");
            updatedUser.DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter Your Updated Email Address:");
            updatedUser.EmailAddress = Console.ReadLine();
            Console.WriteLine("Enter Your Updated Phone Number:");
            updatedUser.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Updated Job Role:");
            updatedUser.JobRole = Console.ReadLine();
            UserService.UpdateUserInformation(updatedUser);
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("Enter the ID of the user that you would like to delete");
            int personToBeDeleted = int.Parse(Console.ReadLine());
            UserService.RemoveUser(personToBeDeleted);
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid menu selection");
            break;
    }
} while (menuSelection != "7" && menuSelection != "exit" );