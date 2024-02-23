using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Console.Shared.Models;

namespace UserManagement.Console.Application.Services
{
    public static class MenuItemService
    {
        private static IEnumerable<MenuItem> menuItems = new List<MenuItem>()
        {
           new MenuItem(1, "Add a new user: Allow the user to input information for a new user and add it to the system."),
           new MenuItem(2, "Add a new job role."),
           new MenuItem(3, "Display all users."),
           new MenuItem(4, "Search for a user."),
           new MenuItem(5, "Update user information."),
           new MenuItem(6, "Delete a user."),
           new MenuItem(7, "Exit the application."),
        };

        public static IEnumerable<MenuItem> GetMenuItems()
        {
           return menuItems;
        }
    }
}
