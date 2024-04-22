using System;
using Welcome.Model;
using Welcome.ViewModel;
using Welcome.View;
using Welcome.Others;
using WelcomeExtended.Data;

namespace Welcome
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User user = new User
            {
                Name = "Siyan Pitov",
                Password = "123456789",
                Role = UserRolesEnum.ADMIN
            };

            UserViewModel userViewModel = new UserViewModel(user);

            UserView userView = new UserView(userViewModel);

            userView.Display();

            Console.ReadKey();

            UserData userData = new UserData();

            User studentUser = new User()
            {
                Name = "student",
                Password = "123",
                Role = UserRolesEnum.STUDENT
            };
            userData.AddUser(studentUser);

            User studentUser1 = new User()
            {
                Name = "Student1",
                Password = "123",
                Role = UserRolesEnum.STUDENT
            };
            userData.AddUser(studentUser1);

            User teacherUser = new User()
            {
                Name = "Teacher",
                Password = "1234",
                Role = UserRolesEnum.PROFESSOR
            };
            userData.AddUser(teacherUser);

            User adminUser = new User()
            {
                Name = "Admin",
                Password = "12345",
                Role = UserRolesEnum.ADMIN
            };
            userData.AddUser(adminUser);

            Console.WriteLine("Welcome! Please enter your username and password.");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            bool isValidUser = userData.ValidateUserLambda(username, password);

            if (isValidUser)
            {
                User user1 = userData.GetUser(username, password);

                if (user != null)
                {
                    Console.WriteLine(user.ToString());
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }
        }
    }
}