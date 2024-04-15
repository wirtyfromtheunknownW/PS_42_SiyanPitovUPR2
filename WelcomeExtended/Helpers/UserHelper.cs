using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    static class UserHelper
    {
        private static object userDataInstance;

        public static string ToString(User user)
        {
            return $"User ID: {user.Id}, Name: {user.Name}, Role: {user.Role}";
        }
        public static string ValidateCredentials(User user, string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return "The name cannot be empty";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return "The password cannot be empty";
            }
            return userDataInstance.ValidateUser(user, name, password);
        }

        public static User GetUser(User user, string name, string password)
        {
            UserData userDataInstance = new UserData();
            return userDataInstance.GetUser(name, password);
        }

    }
}