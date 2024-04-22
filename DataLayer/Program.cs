using DataLayer.Database;

namespace DataLayers
{


    internal class Program
    {


        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {


                var users = context.Users.ToList();
                Console.WriteLine("Въведете потребителско име:");
                string userName = Console.ReadLine();
                Console.WriteLine("Въведете парола:");
                string userPassword = Console.ReadLine();

                // Проверка за валиден потребител и парола
                bool isValidUser = context.Users.Any(u => u.Name == userName && u.Password == userPassword);
                if (isValidUser) { Console.WriteLine("valid"); }

            }
        }
    }
}