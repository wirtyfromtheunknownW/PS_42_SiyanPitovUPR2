using System;
using Welcome.Model;
using Welcome.ViewModel;
using Welcome.View;
using Welcome.Others;

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

            try
            {
                var user1 = new User
                {
                    Name = "krumsata",
                    Password = "123456789",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user1);

                var view = new UserView(viewModel);

                view.Display();

                view.DisplayError();
            }
            catch (Exception e)
            {
                ActionOnError log = LogError;

                log(e);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }

            static void LogError(Exception error)
            {
                Console.WriteLine($"Error occurred: {error.Message}");
            }

        }
    }
}