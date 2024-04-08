using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    internal class UserViewModel
    {
        private User _user { get; set; }
        public UserViewModel(User user)
        {
            this._user = user;
        }

        public string Name 
        {  get { return _user.Name; }
           set { _user.Name = value; } }

        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }

        public UserRolesEnum Roles 
        {
            get { return _user.Roles; }
            set { _user.Roles = value; }
        }
    }
}
