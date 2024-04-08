using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User obj = new User("wirt", "1234", Others.UserRolesEnum.ADMIN);
            UserViewModel newobj = new UserViewModel(obj);
            UserView view = new UserView(newobj);

            view.Display();
        }
    }
}
