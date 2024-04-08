using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Welcome.Model;
using Welcome.Others;
using Welcome.ViewModel;

namespace Welcome.View
{
   
    internal class UserView 
    {
        private UserViewModel _viewModel {  get; set; }

        public UserView(UserViewModel viewModel)

        {
            this._viewModel = viewModel;

        }

        public void Display()
        {
            Console.WriteLine("Welcome\n");
            Console.WriteLine($"User: {_viewModel.Name} ");
            Console.WriteLine($"Role: {_viewModel.Roles}");
            
        }
    }
}
