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
        private static object userDataInstance = new UserData();

        public static string ToString(User user)
        {
            return $"User ID: {user.Id}, Name: {user.Name}, Role: {user.Role}";
        }
        public static bool ValidateCredentials(UserData user, string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine( "The name cannot be empty");
                return false ;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("The password cannot be empty");
                return false;
            }
            bool isValid = user.ValidateUser(name, password);
            if ((isValid))
            {
                Console.WriteLine("success");
                return true;
                
            }
            else {
                Console.WriteLine("The name or password are wrong ");
                return false;
            }
        }

        public static User GetUser(User user, string name, string password)
        {
            UserData userDataInstance = new UserData();
            return userDataInstance.GetUser(name, password);
        }

    }
}